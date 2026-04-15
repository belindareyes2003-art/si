using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areadelrapecio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalacular_Click(object sender, EventArgs e)
        {
            double baseMayor = Convert.ToDouble(textBox1.Text);
            double baseMenor = Convert.ToDouble(textBox2.Text);
            double altura= Convert.ToDouble(textBox3.Text);

            double area = ((baseMayor + baseMenor) * altura) / 2;
            textBox4.Text = area.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
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
