using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaGrafica
{
    public partial class Form1 : Form
    {
        CapaDatos.Class.ClsArticulo Pr = new CapaDatos.Class.ClsArticulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pr.Titulo = txtTitulo.Text;
            Pr.Correo = txtCorreo.Text;
            Pr.Tipo = txtTipo.Text;
            Pr.IdArt = -1;
            Pr.AdministrarArticulo(Pr, "I");
        }
    }
}
