using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areadelpoligono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int lado = (int)Convert.ToDouble(txtlados1.Text);
            double longitud = Convert.ToDouble(txtlados2.Text);
            double perimetro = lado * longitud;

            double apometa = lado / (2 * Math.Tan(Math.PI / lado));

            double area = (perimetro * apometa) / 2;
            txtarea.Text = area.ToString("F2");
            MessageBox.Show("La apometa es: " + apometa.ToString());
            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtlados1.Text = "";
            txtlados2.Text = "";
            txtarea.Text = "";
            txtlados1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("¿Desea salir del programa?", "Salir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
