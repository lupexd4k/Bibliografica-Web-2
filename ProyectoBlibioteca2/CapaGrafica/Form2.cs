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
    public partial class Form2 : Form
    {
        CapaDatos.Class.ClsArticulo Art = new CapaDatos.Class.ClsArticulo();
        CapaDatos.Class.ClsCentro Cen = new CapaDatos.Class.ClsCentro();
        CapaDatos.Class.ClsPalabraClave Pal = new CapaDatos.Class.ClsPalabraClave();
        CapaDatos.Class.ClsInformeTecnico Inf = new CapaDatos.Class.ClsInformeTecnico();

        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Art.Tipo = "I";
            Art.IdArt = 0;
            Art.Titulo = txtTitulo.Text;
            Art.Correo = txtCorreo.Text;
            Cen.Descripcion = txtCentro.Text;
            Inf.Mes = int.Parse(txtMes.Text);
            Inf.Anio = int.Parse(txtAnio.Text);
            Art.AdministrarArticulo(Art, Cen, Inf);
            
        }
    }
}
