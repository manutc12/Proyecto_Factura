using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaAppAlpha
{
    class Factura
    {
        public string IdUsuario { get; set; }
        public string rut { get; set; }
        public string FechaFactura { get; set; }
        public string FechaVencimiento { get; set; }
        public string NumeroFactura { get; set; }
        public string Descripcion { get; set; }
       
        public string Direccion { get; set; }
        public string CodigoProducto { get; set; }
        public string Cantidad { get; set; }
        public string PrecioProducto { get; set; }
        public int subtotal { get; set; }
        public double MontoDescuento { get; set; }
        public  int Subtotal(int cantidad, int precio)
        {
            int total;
            total = cantidad * precio;
            return total;
        }
    }
}
