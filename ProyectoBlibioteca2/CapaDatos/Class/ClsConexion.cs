using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    class ClsConexion
    {
        public String coneccion = "Data Source = SQL5102.site4now.net;" +
         "Initial Catalog=DB_A6E828_WilberthMartinez;" +
         "User id=DB_A6E828_WilberthMartinez_Admin;" +
         "Password=qwert123;";
        //public String coneccion = "Data Source=localhost;Initial Catalog=DbExpediente;Integrated Security=True";
        //public String coneccion = "Server=localhost, Authentication=Windows Authentication, Database= DbExpediente";
        //public String coneccion = "Data Source=LEONY-PC;Initial Catalog=NORTHWND;Integrated Security=True";
        public Boolean Conectando()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(this.coneccion);//Probamos que ahy coneccion.
                cnn.Close();//Cerramos la coneccion
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

