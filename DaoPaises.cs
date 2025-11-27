using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PaisesEstadosCidades
{
    class DaoPaises : Dao<Paises>
    {
        public override string Excluir(object obj)
        {
            Paises opais = (Paises)obj;
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                try
                {
                    string msql = "DELETE FROM paises WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(msql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", opais.Codigo);
                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                            mOk = "Registro excluído com sucesso.";
                        else
                            mOk = "Registro não encontrado.";
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        mOk = "Não é possível excluir o País. Existem Estados ou Cidades cadastrados que dependem dele.";
                    }
                    else
                    {
                        mOk = "Erro de exclusão no banco de dados: " + ex.Message;
                    }
                }
                catch (Exception ex)
                {
                    mOk = "Erro inesperado ao tentar excluir: " + ex.Message;
                }
            }

            return mOk;
        }

        public override string Salvar(object obj)
        {
            Paises opais = (Paises)obj;
            string msql = "";
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                if (opais.Codigo == 0)
                {
                    msql = "INSERT INTO paises (Pais, Sigla, DDI, Moeda, DatCad, UltAlt) " +
                           "VALUES (@Pais, @Sigla, @DDI, @Moeda, @DatCad, @UltAlt)";
                }
                else
                {
                    msql = "UPDATE paises SET Pais=@Pais, Sigla=@Sigla, DDI=@DDI, Moeda=@Moeda, " +
                           "DatCad=@DatCad, UltAlt=@UltAlt WHERE id=@Codigo";
                }

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Pais", opais.Pais);
                    cmd.Parameters.AddWithValue("@Sigla", opais.Sigla);
                    cmd.Parameters.AddWithValue("@DDI", opais.Ddi);
                    cmd.Parameters.AddWithValue("@Moeda", opais.Moeda);
                    cmd.Parameters.AddWithValue("@DatCad", opais.Datcad);
                    cmd.Parameters.AddWithValue("@UltAlt", opais.Ultalt);
                    cmd.Parameters.AddWithValue("@Codigo", opais.Codigo);

                    cmd.ExecuteNonQuery();

                    if (opais.Codigo == 0)
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        mOk = cmd.ExecuteScalar().ToString();
                    }
                    else
                    {
                        mOk = opais.Codigo.ToString();
                    }
                }
            }

            return mOk;
        }

        public override List<Paises> Listar()
        {
            List<Paises> lista = new List<Paises>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT id, pais, sigla, ddi, moeda, DatCad, UltAlt FROM paises ORDER BY pais";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Paises op = new Paises();
                        op.Codigo = Convert.ToInt32(dr["id"]);
                        op.Pais = dr["pais"].ToString();
                        op.Sigla = dr["sigla"].ToString();
                        op.Ddi = dr["ddi"].ToString();
                        op.Moeda = dr["moeda"].ToString();
                        op.Datcad = Convert.ToDateTime(dr["DatCad"]);

                        if (dr["UltAlt"] != DBNull.Value)
                            op.Ultalt = Convert.ToDateTime(dr["UltAlt"]);
                        else
                            op.Ultalt = DateTime.MinValue;

                        lista.Add(op);
                    }
                }
            }

            return lista;
        }

        public override Object CarregaObj(int chave)
        {
            Paises op = null;

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT id, pais, sigla, ddi, moeda, DatCad, UltAlt FROM paises WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", chave);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            op = new Paises();
                            op.Codigo = Convert.ToInt32(dr["id"]);
                            op.Pais = dr["pais"].ToString();
                            op.Sigla = dr["sigla"].ToString();
                            op.Ddi = dr["ddi"].ToString();
                            op.Moeda = dr["moeda"].ToString();
                            op.Datcad = Convert.ToDateTime(dr["DatCad"]);

                            if (dr["UltAlt"] != DBNull.Value)
                                op.Ultalt = Convert.ToDateTime(dr["UltAlt"]);
                            else
                                op.Ultalt = DateTime.MinValue;
                        }
                    }
                }
            }

            return op;
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            List<T> lista = new List<T>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT id, pais, sigla, ddi, moeda, DatCad, UltAlt FROM paises " +
                              "WHERE pais LIKE @chave ORDER BY pais";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Paises op = new Paises();
                            op.Codigo = Convert.ToInt32(dr["id"]);
                            op.Pais = dr["pais"].ToString();
                            op.Sigla = dr["sigla"].ToString();
                            op.Ddi = dr["ddi"].ToString();
                            op.Moeda = dr["moeda"].ToString();
                            op.Datcad = Convert.ToDateTime(dr["DatCad"]);

                            if (dr["UltAlt"] != DBNull.Value)
                                op.Ultalt = Convert.ToDateTime(dr["UltAlt"]);
                            else
                                op.Ultalt = DateTime.MinValue;

                            lista.Add((T)(object)op);
                        }
                    }
                }
            }

            return lista;
        }


    }
}
