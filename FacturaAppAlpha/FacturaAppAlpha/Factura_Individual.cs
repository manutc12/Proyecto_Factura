using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaAppAlpha
{
    public partial class Factura_Individual : Form
    {

        List<Factura> factura = new List<Factura>();
        List<Clientes> facturarut = new List<Clientes>();
        List<Producto> producto = new List<Producto>();
        public Factura_Individual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Factura_Individual_Load(object sender, EventArgs e)
        {
            facturarut.Add(new Clientes() { rut = "20206555-4", nombre = "Manuel", direccion = "Urmeneta 050" });
            facturarut.Add(new Clientes() { rut = "20300500-4", nombre = "Juan", direccion = "O'Higgins 12" });
            facturarut.Add(new Clientes() { rut = "18222555-0", nombre = "Pedro", direccion = "Covadonga 933" });
            producto.Add(new Producto() { Codigo = "9988", Descripcion = "Telefono", PrecioUnitario = 90000 });
            producto.Add(new Producto() { Codigo = "1141", Descripcion = "Tv Smart tv", PrecioUnitario = 120000 });
            producto.Add(new Producto() { Codigo = "2344", Descripcion = "Horno", PrecioUnitario = 85000 });
        }
        int iva = 0;
        double Iva = 0;
        double montototal = 0;
        double montofinal = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Lo siento, la factura no se pudo ingresar porque algun campo no esta inscrito correctamente o esta vacio, porfavor verifica que los campos esten escritos correctamente  ");
            }
            else
            {



                foreach (var dato in facturarut)
                {
                    foreach (var cod in producto)
                    {



                        try
                        {
                            if (textBox2.Text == dato.rut && textBox7.Text == cod.Codigo)
                            {

                                Factura f = new Factura();
                                int sub;
                                sub = f.Subtotal(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));

                                factura.Add(new Factura() { IdUsuario = textBox1.Text, rut = textBox2.Text, FechaFactura = textBox3.Text, FechaVencimiento = textBox4.Text, NumeroFactura = textBox5.Text, Direccion = textBox6.Text, CodigoProducto = textBox7.Text, Descripcion = textBox11.Text, Cantidad = textBox8.Text, PrecioProducto = textBox9.Text, subtotal = sub, MontoDescuento = Convert.ToDouble(textBox10.Text) });
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = factura;

                                Iva = sub * 0.19;
                                montototal = sub + Iva;
                                montofinal = montototal - Convert.ToDouble(textBox10.Text);

                                label15.Text = Convert.ToString(Iva);
                                label16.Text = Convert.ToString(montototal);
                                label18.Text = Convert.ToString(montofinal);
                                //iva = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                                //MessageBox.Show("La sumatoria es :" + iva);
                                //iva = 0;


                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                                textBox8.Clear();
                                textBox9.Clear();
                                textBox10.Clear();

                                textBox11.Clear();
                            }
                            
                        }
                        catch
                        {
                            MessageBox.Show("Verifica tu rut que este escrito de esta manera >>> 111111-0 <<<" +
                               " o que el codigo de producto sea valido");
                        }
                        
                       
                            

                        






                    }
                    






                }
              
              








            }

        }





        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            foreach (var dato in facturarut)
            {
                if (textBox2.Text == dato.rut)
                {
                    textBox1.Text = dato.nombre;
                    textBox6.Text = dato.direccion;
                }

            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            foreach (var cod in producto)
            {

                if (textBox7.Text == cod.Codigo)
                {

                    textBox9.Text = Convert.ToString(cod.PrecioUnitario);
                    textBox11.Text = cod.Descripcion;


                }
              

            }

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            foreach (var dato1 in factura)
            {
                if (textBox5.Text == dato1.NumeroFactura)
                {
                    MessageBox.Show("Ingresa una nueva factura");
                }
                else
                {

                }
            }
        }
    }
}

