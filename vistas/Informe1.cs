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

namespace Jacaton.vistas
{
    public partial class Informe1 : Form
    {
        public Informe1()
        {
            InitializeComponent();
            DataTable tabla = Conexion.InformeUno();
            Tabla.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
