using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pruebas
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        CapaDatos.Class.ClsArticulo Pr = new Class.ClsArticulo();
        private void button1_Click(object sender, EventArgs e)
        {
            Pr.Titulo = txttitulo.ToString();
            Pr.Correo = txtcorreo.ToString();
            Pr.Tipo = txtcorreo.ToString();
            Pr.AdministrarArticulo(Pr, "I");
        }
    }
}
