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
    public partial class Informe4 : Form
    {
        public Informe4()
        {
            InitializeComponent();
            DataTable tabla = BBDD.Conexion.InformeCuatro();
            Tabla.DataSource = tabla;
        }

        private void Informe4_Load(object sender, EventArgs e)
        {

        }
    }
}
