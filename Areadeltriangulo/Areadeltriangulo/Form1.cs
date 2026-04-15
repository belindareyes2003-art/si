using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areadeltriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double baseValue = Convert.ToDouble(txtbase.Text);
            double altura = Convert.ToDouble(txtaltura.Text);
            double area = baseValue * altura;

            txtrespuesta.Text = area.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbase.Text = "";
            txtaltura.Text = "";
            txtrespuesta.Text = "";
            txtbase.Focus();
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
