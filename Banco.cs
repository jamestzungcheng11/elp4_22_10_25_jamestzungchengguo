using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaisesEstadosCidades
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\james\Documents\elp4_25_22_09_jamestzungcheng\PaisesEstadosCidades\PaisesEstadosCidades\ELP42025.mdf;Integrated Security=True";

          
            SqlConnection cnn=new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }

    }
}
