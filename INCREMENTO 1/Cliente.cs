using Rodriguez.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodriguez.Entitites
{
    class Cliente
    {
        private Int16 idcliente;

        public Int16 Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }


        private string dni;

        public string Dni
        {
            get { return dni; }
            set {
                //if (!Validator.isDNI(value.Trim())) throw new Exception("El valor de DNI tiene formato erroneo");
                //else
                dni = value;
            }
        }


        private string razonsocial;

        public string Razonsocial
        {
            get { return razonsocial; }
            set { razonsocial = value.ToUpper(); }
        }





        private string ruc;

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
  


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper();
                //if (String.IsNullOrEmpty(value)) throw new Exception("El valor de nombre no puede ser nulo ni vacio");
                //else if (value.Length > 50) throw new Exception("la longitud de nombre no puede superar los 50 caracteres"); 
                
                //else
                    nombre = value.ToUpper();
            }
        }


        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {   apellido = value.ToUpper();
                //if (String.IsNullOrEmpty(value)) throw new Exception("El valor de apellido no puede ser nulo ni vacio");
                //else if (value.Length > 50) throw new Exception("la longitud de apellido no puede superar los 50 caracteres");

                //else
                apellido = value.ToUpper();
            }
        }


        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de direccion no puede ser nulo ni vacio");
                else if (value.Length > 100) throw new Exception("la longitud de direccion no puede superar los 100 caracteres");
                else direccion = value.ToUpper();
            }
        }


        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de telefono no puede ser nulo ni vacio");
                else if (value.Length > 20) throw new Exception("la longitud de telefono no puede superar los 20 caracteres"); 
                else telefono = value; }
        }


        private string correo;

        public string Correo
        {
            get { return correo; }
            set {
                if (!Validator.isEmail(value.Trim())) throw new Exception("El valor de E-mail tiene formato erroneo");
                else correo = value.ToUpper();
            }
        }

        private List<Venta> ventas;

        internal List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

    }
}
