using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class DaoCidades:Dao
    {

        public override string Excluir(object obj)
        {
            return null;

        }

        public override string Salvar(object obj)
        {
            Cidades ocidade = (Cidades)obj;
            string msql = "";
            string mOk = "";

            // Abre conexão
            using (SqlConnection cnn = Banco.Abrir())
            {
                if (ocidade.Codigo == 0)
                {
                    msql = "INSERT INTO cidades (cidade, ddd, idestado, DatCad, UltAlt) " +
                           "VALUES (@cidade, @ddd, @idestado, @DatCad, @UltAlt)";
                }
                else
                {
                    msql = "UPDATE cidades SET cidade=@cidade, ddd=@ddd, idestado=@idestado," +
                           "DatCad=@DatCad, UltAlt=@UltAlt WHERE Codigo=@Codigo";
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

        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<T> Pesquisar<T>(string chave)
        {
            return null;
        }

    }
}

    

