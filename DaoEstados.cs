using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PaisesEstadosCidades
{
    class DaoEstados : Dao
    {
        public override string Excluir(object obj)
        {
            return null;
        }

        public override string Salvar(object obj)
        {
            Estados oestado = (Estados)obj;
            string msql;
            string mOk = "";

            using (SqlConnection cnn = Banco.Abrir())
            {
                if (oestado.Codigo == 0)
                {
                    msql = @"INSERT INTO estados (estados, uf, idpais)
                             VALUES (@estados, @uf, @idpais);
                             SELECT SCOPE_IDENTITY();";
                }
                else
                {
                    msql = @"UPDATE estados 
                             SET estados=@estados, uf=@uf, idpais=@idpais, UltAlt=GETDATE()
                             WHERE Id=@Id;";
                }

                using (SqlCommand cmd = new SqlCommand(msql, cnn))
                {
                    cmd.Parameters.AddWithValue("@estados", oestado.Estado);
                    cmd.Parameters.AddWithValue("@uf", oestado.Uf);
                    cmd.Parameters.AddWithValue("@idpais", oestado.Opais.Codigo);
                    cmd.Parameters.AddWithValue("@Id", oestado.Codigo);

                    if (oestado.Codigo == 0)
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            mOk = result.ToString();
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        mOk = oestado.Codigo.ToString();
                    }
                }
            }

            return mOk;
        }

        public override object CarregaObj(int chave)
        {
            return null;
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            return null;
        }
    }
}
