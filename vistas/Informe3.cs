using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Jacaton
{
    public partial class Informe3 : Form
    {
        public Informe3()
        {
            InitializeComponent();
        }

        private void comboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total;
            int seccion = Convert.ToInt32(comboSeccion.SelectedItem);
            DataTable tabla = BBDD.Conexion.InformeTres(seccion, out total);
            Tabla.DataSource = tabla;
            labelSeccion.Text = total.ToString();
        }
    }
    
}
