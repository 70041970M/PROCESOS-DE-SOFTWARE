using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodriguez.Entitites
{
    class Producto
    {

        private Int16 idproducto;

        public Int16 Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }



        private Int16 stock;

        public Int16 Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value.ToUpper(); }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { if (String.IsNullOrEmpty(value)) throw new Exception("El valor de nombre no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de nombre no puede superar los 50 caracteres");

            else nombre = value.ToUpper();
            }
        }


        private string diseño;

        public string Diseño
        {
            get { return diseño; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de diseño no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de diseño no puede superar los 50 caracteres");
                else diseño = value.ToUpper();
            }
        }


        private string material;

        public string Material
        {
            get { return material; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de material no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de material no puede superar los 50 caracteres");
                else material = value.ToUpper();
            }
        }


        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set {
                if (value.Length > 150) throw new Exception("la longitud de descripcion no puede superar los 150 caracteres");
                else descripcion = value.ToUpper();
            }
        }


        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private string tamaño;

        public string Tamaño
        {
            get { return tamaño; }
            set {

                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de tamaño no puede ser nulo ni vacio");
                else if (value.Length > 20) throw new Exception("la longitud de tamaño no puede superar los 20 caracteres");
                else tamaño = value.ToUpper();
            }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value.ToUpper(); }
        }

        private Int32 cantidad;

        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //--- Un producto aparece en varios Detalles
        private List<VentaDetalle> ventaDetalles;

        internal List<VentaDetalle> VentaDetalles
        {
            get { return ventaDetalles; }
            set { ventaDetalles = value; }
        }

    }
}
