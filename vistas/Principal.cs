using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jacaton.BBDD;
using Jacaton.vistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jacaton
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Conexion.ConsultarResumenVentas(labelCat, labelVol, labelVen);
            DataTable tabla1 = BBDD.Conexion.TablaTienda();
            Tabla1.DataSource = tabla1;
            DataTable tabla2 = BBDD.Conexion.TablaOnline();
            Tabla2.DataSource = tabla2;
        }

        private void botoninfo1_Click(object sender, EventArgs e)
        {
            Informe1 informe1 = new Informe1();
            informe1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botoninfo2_Click(object sender, EventArgs e)
        {
            Informe2 informe2 = new Informe2();
            informe2.ShowDialog();
        }

        private void botoninfo3_Click(object sender, EventArgs e)
        {
            Informe3 informe3 = new Informe3();
            informe3.ShowDialog();
        }

        private void botoninfo4_Click(object sender, EventArgs e)
        {
            Informe4 informe4 = new Informe4();
            informe4.ShowDialog();
        }

        private void botoninfo5_Click(object sender, EventArgs e)
        {
            Informe5 informe5 = new Informe5();
            informe5.ShowDialog();
        }
    }
}
