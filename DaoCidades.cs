using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PaisesEstadosCidades
{
    class DaoCidades : Dao<Cidades>
    {
        public override string Excluir(object obj)
        {
            Cidades ocidade = (Cidades)obj;
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                try
                {
                    string msql = "DELETE FROM cidades WHERE Id=@Id";

                    using (SqlCommand cmd = new SqlCommand(msql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Id", ocidade.Codigo);
                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                            mOk = "Cidade excluída com sucesso.";
                        else
                            mOk = "Cidade não encontrada.";
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        mOk = "Não é possível excluir a cidade. Existem dependências.";
                    else
                        mOk = "Erro ao excluir: " + ex.Message;
                }
                catch (Exception ex)
                {
                    mOk = "Erro inesperado: " + ex.Message;
                }
            }

            return mOk;
        }

        public override string Salvar(object obj)
        {
            Cidades ocidade = (Cidades)obj;
            string msql = "";
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                if (ocidade.Codigo == 0)
                {
                    msql = @"INSERT INTO cidades 
                                (cidade, ddd, idestado, DatCad, UltAlt)
                             VALUES
                                (@cidade, @ddd, @idestado, @DatCad, @UltAlt)";
                }
                else
                {
                    msql = @"UPDATE cidades SET 
                                cidade=@cidade, 
                                ddd=@ddd, 
                                idestado=@idestado,
                                DatCad=@DatCad, 
                                UltAlt=@UltAlt
                             WHERE Id=@Codigo";
                }

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@cidade", ocidade.Cidade);
                    cmd.Parameters.AddWithValue("@ddd", ocidade.Ddd);
                    cmd.Parameters.AddWithValue("@idestado", ocidade.Oestados.Codigo);
                    cmd.Parameters.AddWithValue("@DatCad", ocidade.Datcad);
                    cmd.Parameters.AddWithValue("@UltAlt", ocidade.Ultalt);
                    cmd.Parameters.AddWithValue("@Codigo", ocidade.Codigo);

                    cmd.ExecuteNonQuery();

                    if (ocidade.Codigo == 0)
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        mOk = cmd.ExecuteScalar().ToString();
                    }
                    else
                    {
                        mOk = ocidade.Codigo.ToString();
                    }
                }
            }

            return mOk;
        }

        public override List<Cidades> Listar()
        {
            List<Cidades> lista = new List<Cidades>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = @"
                SELECT c.Id,
                       c.cidade,
                       c.ddd,
                       c.idestado,
                       c.DatCad,
                       c.UltAlt,
                       e.estados AS NomeEstado,
                       e.uf,
                       e.idpais
                FROM cidades c
                INNER JOIN estados e ON e.Id = c.idestado
                ORDER BY c.cidade";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cidades ci = new Cidades();

                        ci.Codigo = Convert.ToInt32(dr["Id"]);
                        ci.Cidade = dr["cidade"].ToString();
                        ci.Ddd = dr["ddd"].ToString();

                        // Estado
                        ci.Oestados = new Estados();
                        ci.Oestados.Codigo = Convert.ToInt32(dr["idestado"]);
                        ci.Oestados.Estado = dr["NomeEstado"].ToString();
                        ci.Oestados.Uf = dr["uf"].ToString();

                        // Datas
                        ci.Datcad = Convert.ToDateTime(dr["DatCad"]);
                        ci.Ultalt = dr["UltAlt"] != DBNull.Value
                                    ? Convert.ToDateTime(dr["UltAlt"])
                                    : DateTime.MinValue;

                        lista.Add(ci);
                    }
                }
            }

            return lista;
        }

        public override object CarregaObj(int chave)
        {
            Cidades ci = null;

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = @"
                SELECT c.Id,
                       c.cidade,
                       c.ddd,
                       c.idestado,
                       c.DatCad,
                       c.UltAlt,
                       e.estados AS NomeEstado,
                       e.uf
                FROM cidades c
                INNER JOIN estados e ON e.Id = c.idestado
                WHERE c.Id=@Id";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", chave);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ci = new Cidades();

                            ci.Codigo = Convert.ToInt32(dr["Id"]);
                            ci.Cidade = dr["cidade"].ToString();
                            ci.Ddd = dr["ddd"].ToString();

                            ci.Oestados = new Estados();
                            ci.Oestados.Codigo = Convert.ToInt32(dr["idestado"]);
                            ci.Oestados.Estado = dr["NomeEstado"].ToString();
                            ci.Oestados.Uf = dr["uf"].ToString();

                            ci.Datcad = Convert.ToDateTime(dr["DatCad"]);
                            ci.Ultalt = dr["UltAlt"] != DBNull.Value
                                        ? Convert.ToDateTime(dr["UltAlt"])
                                        : DateTime.MinValue;
                        }
                    }
                }
            }

            return ci;
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            List<T> lista = new List<T>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = @"
                SELECT c.Id,
                       c.cidade,
                       c.ddd,
                       c.idestado,
                       c.DatCad,
                       c.UltAlt,
                       e.estados AS NomeEstado
                FROM cidades c
                INNER JOIN estados e ON e.Id = c.idestado
                WHERE c.cidade LIKE @chave
                ORDER BY c.cidade";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cidades ci = new Cidades();

                            ci.Codigo = Convert.ToInt32(dr["Id"]);
                            ci.Cidade = dr["cidade"].ToString();
                            ci.Ddd = dr["ddd"].ToString();

                            ci.Oestados = new Estados();
                            ci.Oestados.Codigo = Convert.ToInt32(dr["idestado"]);
                            ci.Oestados.Estado = dr["NomeEstado"].ToString();

                            ci.Datcad = Convert.ToDateTime(dr["DatCad"]);
                            ci.Ultalt = dr["UltAlt"] != DBNull.Value
                                        ? Convert.ToDateTime(dr["UltAlt"])
                                        : DateTime.MinValue;

                            lista.Add((T)(object)ci);
                        }
                    }
                }
            }

            return lista;
        }
    }
}

   

    

