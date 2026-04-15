using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areadelrombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(txtd1.Text);
            double d2 = Convert.ToDouble(txtd2.Text);

            double area = (d1 * d2) / 2;

            txtarea.Text = area.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtd1.Text = "";
            txtd2.Text = "";
            txtarea.Text = "";
            txtd1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("¿Desea salir del programa?", "Salir",
                MessageBoxButtons.  YesNo, MessageBoxIcon.Question);

            if (Salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
