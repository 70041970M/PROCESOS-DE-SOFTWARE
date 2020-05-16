using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodriguez.Entitites
{
    class VentaDetalle
    {
        private Venta venta;

        internal Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }

        private Producto producto;

        internal Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }


        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        //-------------------------------------------------------
        private Decimal precioUnitario;

        public Decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        //-------------------------------------------------------
        private DateTime fechaEntrega;

        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }

        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }



    }
}
