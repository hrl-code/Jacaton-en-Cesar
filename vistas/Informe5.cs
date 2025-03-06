using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jacaton.vistas
{
    public partial class Informe5 : Form
    {
        public Informe5()
        {
            InitializeComponent();
            DataTable tabla = BBDD.Conexion.InformeCinco();
            Tabla.DataSource = tabla;
        }

        private void Informe5_Load(object sender, EventArgs e)
        {

        }
    }
}
