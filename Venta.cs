using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodriguez.Entitites
{
    class Venta
    {
        private Int32 idVenta;

        public Int32 IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

    

        private DateTime fechaVenta;

        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }


        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value.ToUpper(); }
        }


        // --- Una venta, un solo cliente
        private Cliente cliente;

        internal Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Cliente idcliente;

        internal Cliente Idcliente 
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        private Cliente nombre;

        internal Cliente Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Empleado empleado;

        internal Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }


        // -- Una venta tiene varios detalles
        private List<VentaDetalle> ventaDetalles;

        internal List<VentaDetalle> VentaDetalles
        {
            get { return ventaDetalles; }
            set { ventaDetalles = value; }
        }

        private string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string tipoComprobante;

        public string TipoComprobante
        {
            get { return tipoComprobante; }
            set { tipoComprobante = value.ToUpper(); }
        }

        private decimal igv;

        public decimal Igv
        {
            get { return igv; }
            set { igv = value; }
        }

        private string comprobante;

        public string Comprobante
        {
            get { return comprobante; }
            set { comprobante = value; }
        }
    }
}
