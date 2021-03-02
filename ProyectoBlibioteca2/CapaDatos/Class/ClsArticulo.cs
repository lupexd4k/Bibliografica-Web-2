using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
   public class ClsArticulo 
    {
        CapaDatos.Class.ClsConexion Cn = new CapaDatos.Class.ClsConexion();
        public String Titulo;
            public String Correo;
            public String Tipo;
            public int IdArt;

            public ClsArticulo()
            {
                this.Titulo = "";
                this.Correo = "";
                this.Tipo = "";
                this.IdArt = -1;
            }

            public ClsArticulo(string aTitulo, String aCorreo, string aTipo,int aIdArt)
            {
                this.Titulo = aTitulo;
                this.Correo = aCorreo;
                this.Tipo = aTipo;


                this.IdArt = aIdArt;
            }
            public String AdministrarArticulo(ClsArticulo cArticulo, ClsCentro cCentro,
                ClsInformeTecnico cInforme)
            {
                String vResultado = "";
                if (this.Cn.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.Cn.coneccion);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand();
                        coneccion.Connection = conectado;
                        coneccion.CommandType = CommandType.StoredProcedure;
                        coneccion.CommandText = "sp_AdministrarInfoTecnico";
                        coneccion.CommandTimeout = 10;
                        coneccion.Parameters.AddWithValue("@pTitulo", cArticulo.Titulo);
                        coneccion.Parameters.AddWithValue("@pCorreo", cArticulo.Correo);
                        coneccion.Parameters.AddWithValue("@pTipo", cArticulo.Tipo);
                       // coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                        coneccion.Parameters.AddWithValue("@pIdArt", cArticulo.IdArt); 
                        coneccion.ExecuteNonQuery();
                        conectado.Close();
                        vResultado = "Ejecutado con exito";
                    }
                    catch (Exception Ex)
                    {
                        vResultado = Ex.Message;
                    }
                }
                return vResultado;
            }

            private DataSet dataTable = new DataSet();
            public DataSet GetListaArticulo(ClsArticulo cArticulo, String pAccion)
            {
                try
                {
                    SqlDataAdapter adapter;
                    DataSet ds = new DataSet();
                    SqlConnection conectado = new SqlConnection(this.Cn.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "sp_AdministrarArticulo";
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@aTitulo", cArticulo.Titulo);
                    coneccion.Parameters.AddWithValue("@aCorreo", cArticulo.Correo);
                    coneccion.Parameters.AddWithValue("@aTipo", cArticulo.Tipo);
                    coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                    adapter = new SqlDataAdapter(coneccion);
                    adapter.Fill(dataTable);
                    conectado.Close();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                return dataTable;
            }
        }
}
