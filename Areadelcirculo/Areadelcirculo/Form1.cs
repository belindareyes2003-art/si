using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areadelcirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtradio.Text);
            double area = Math.PI * Math.Pow(radio, 2);

            txtarea.Text = area.ToString("F2");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtradio.Text = "";
            txtarea.Text = "";
            txtradio.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("¿Deseas salir del programa?", "Salir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
