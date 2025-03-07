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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jacaton.vistas
{
    public partial class Informe2 : Form
    {
        public Informe2()
        {
            InitializeComponent();
            DataTable tabla1 = Conexion.InformeDos1();
            Tabla1.DataSource = tabla1;

            DataTable tabla2 = Conexion.InformeDos2();
            Tabla2.DataSource = tabla2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
