using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class DaoPaises:Dao
    {

        public override string  Excluir(object obj)
        {
            return null; 

        }
       
        public override string Salvar(object obj)
        {
            Paises opais = (Paises)obj;
            string msql = "";
            string mOk = "";

            // Abre conexão
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
                           "DatCad=@DatCad, UltAlt=@UltAlt WHERE Codigo=@Codigo";
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

                    // Se for inserção, pega o ID gerado
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

        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<T>Pesquisar<T>(string  chave)
        {
            return null;
        }

    }
}
