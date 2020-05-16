using Rodriguez.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodriguez.Entitites
{
    class Empleado
    {

        private Int16 idempleado;

        public Int16 Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
        

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de nombre no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de nombre no puede superar los 50 caracteres");

                else nombre = value.ToUpper(); }
        }


        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de apellido no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de apellido no puede superar los 50 caracteres");

                else apellido = value.ToUpper(); }
        }


        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de direccion no puede ser nulo ni vacio");
                else if (value.Length > 100) throw new Exception("la longitud de direccion no puede superar los 100 caracteres");
                else direccion = value.ToUpper(); }
        }


        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de cargo no puede ser nulo ni vacio");
                else if (value.Length > 50) throw new Exception("la longitud de cargo no puede superar los 50 caracteres");
                else cargo = value.ToUpper();
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


        private string dni;

        public string Dni
        {
            get { return dni; }
            set {
                if (!Validator.isDNI(value.Trim())) throw new Exception("El valor de DNI tiene formato erroneo");
                else dni = value;
                dni = value; }
        }


        private DateTime fechanacimiento;

        public DateTime Fechanacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }


        private DateTime fechaentrada;

        public DateTime Fechaentrada
        {
            get { return fechaentrada; }
            set { fechaentrada = value; 
            }
        }

        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set {
                if (String.IsNullOrEmpty(value)) throw new Exception("El valor de contraseña no puede ser nulo ni vacio");
                else if (value.Length > 10) throw new Exception("la longitud de contraseña no puede superar los 10 caracteres");
                else contraseña = value; }
        }
        
        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private List<Venta> ventas;

        internal List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }
    }
}
