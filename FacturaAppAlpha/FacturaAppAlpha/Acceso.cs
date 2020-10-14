using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaAppAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string usuario = (Convert.ToString(textBox1.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string contraseña = (Convert.ToString(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ivan" && textBox2.Text == "123")
            {
                label4.Text = "Ingresaste correctamente";
                Menu mv = new Menu();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
            else
            {
                label4.Text = "Ingresa nuevamente";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
