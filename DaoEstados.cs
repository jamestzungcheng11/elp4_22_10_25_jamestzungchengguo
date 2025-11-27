using System.Collections.Generic;
using System.Data.SqlClient;
using System;


namespace PaisesEstadosCidades
{
    class DaoEstados : Dao<Estados>
    {
        public override string Excluir(object obj)
        {
            Estados est = (Estados)obj;
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                try
                {
                    string msql = "DELETE FROM estados WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(msql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", est.Codigo);
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
                        mOk = "Não é possível excluir o Estado, pois há Cidades cadastradas vinculadas a ele.";
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
            Estados est = (Estados)obj;
            string msql = "";
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                if (est.Codigo == 0)
                {
                    msql = "INSERT INTO estados (estados, uf, idpais, DatCad, UltAlt) " +
                           "VALUES (@estados, @uf, @idpais, @DatCad, @UltAlt)";
                }
                else
                {
                    msql = "UPDATE estados SET estados=@estados, uf=@uf, idpais=@idpais, " +
                           "DatCad=@DatCad, UltAlt=@UltAlt WHERE id=@Codigo";
                }

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@estados", est.Estado);
                    cmd.Parameters.AddWithValue("@uf", est.Uf);
                    cmd.Parameters.AddWithValue("@idpais", est.Opais.Codigo);
                    cmd.Parameters.AddWithValue("@DatCad", est.Datcad);
                    cmd.Parameters.AddWithValue("@UltAlt", est.Ultalt);
                    cmd.Parameters.AddWithValue("@Codigo", est.Codigo);

                    cmd.ExecuteNonQuery();

                    if (est.Codigo == 0)
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        mOk = cmd.ExecuteScalar().ToString();
                    }
                    else
                    {
                        mOk = est.Codigo.ToString();
                    }
                }
            }

            return mOk;
        }

        public override List<Estados> Listar()
        {
            List<Estados> lista = new List<Estados>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT Id, estados, uf, idpais, DatCad, UltAlt FROM estados ORDER BY estados";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estados est = new Estados();
                        est.Codigo = Convert.ToInt32(dr["Id"]);
                        est.Estado = dr["estados"].ToString();
                        est.Uf = dr["uf"].ToString();

                        // carregar objeto Paises com o código
                        est.Opais = new Paises
                        {
                            Codigo = Convert.ToInt32(dr["idpais"])
                        };

                        est.Datcad = Convert.ToDateTime(dr["DatCad"]);
                        est.Ultalt = dr["UltAlt"] != DBNull.Value
                            ? Convert.ToDateTime(dr["UltAlt"])
                            : DateTime.MinValue;

                        lista.Add(est);
                    }
                }
            }

            return lista;
        }

        public override object CarregaObj(int chave)
        {
            Estados est = null;

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT Id, estados, uf, idpais, DatCad, UltAlt " +
                              "FROM estados WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", chave);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            est = new Estados();
                            est.Codigo = Convert.ToInt32(dr["Id"]);
                            est.Estado = dr["estados"].ToString();
                            est.Uf = dr["uf"].ToString();

                            est.Opais = new Paises
                            {
                                Codigo = Convert.ToInt32(dr["idpais"])
                            };

                            est.Datcad = Convert.ToDateTime(dr["DatCad"]);
                            est.Ultalt = dr["UltAlt"] != DBNull.Value
                                ? Convert.ToDateTime(dr["UltAlt"])
                                : DateTime.MinValue;
                        }
                    }
                }
            }

            return est;
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            List<T> lista = new List<T>();

            using (SqlConnection cnn = Banco.Abrir())
            {
                string msql = "SELECT Id, estados, uf, idpais, DatCad, UltAlt FROM estados " +
                              "WHERE estados LIKE @chave ORDER BY estados";

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Estados est = new Estados();
                            est.Codigo = Convert.ToInt32(dr["Id"]);
                            est.Estado = dr["estados"].ToString();
                            est.Uf = dr["uf"].ToString();

                            est.Opais = new Paises
                            {
                                Codigo = Convert.ToInt32(dr["idpais"])
                            };

                            est.Datcad = Convert.ToDateTime(dr["DatCad"]);
                            est.Ultalt = dr["UltAlt"] != DBNull.Value
                                ? Convert.ToDateTime(dr["UltAlt"])
                                : DateTime.MinValue;

                            lista.Add((T)(object)est);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
