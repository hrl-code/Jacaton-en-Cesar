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
        private bool isInitializing = true;

        public Informe3()
        {
            InitializeComponent();
            comboSeccion.SelectedIndex = 0;

            this.Load += Informe3_Load;
        }

        private void Informe3_Load(object sender, EventArgs e)
        {

            isInitializing = false;
        }

        private void comboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;

            if (comboSeccion.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una seccion");
                Tabla.DataSource = null;
                labelSeccion.Text = "0";

            }
            else
            {
                int total;
                int seccion = Convert.ToInt32(comboSeccion.SelectedItem);
                DataTable tabla = BBDD.Conexion.InformeTres(seccion, out total);
                Tabla.DataSource = tabla;
                labelSeccion.Text = total.ToString();
            }
        }
    }
}