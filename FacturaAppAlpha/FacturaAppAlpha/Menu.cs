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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Factura consultar = new Consultar_Factura();
            consultar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MenuIngresar ingresar = new MenuIngresar();
            ingresar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anular_Factura anular = new Anular_Factura();
            anular.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar_Factura eliminar = new Eliminar_Factura();
            eliminar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
