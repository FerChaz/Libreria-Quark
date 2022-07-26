using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class Prestamo
    {
        private Ejemplar ejemplarPrestado;
        private Socio socio;
        private DateTime fechaPrestamo;
        private string estadoPrestamo;

        public string ISBN
        {
            get { return ejemplarPrestado.ISBN; }
        }
        public string NombreSocio
        {
            get { return socio.NombreApellido; }
        }
        public string FechaPrestamo
        {
            get { return fechaPrestamo.ToString(); }
        }
        public string EstadoPrestamo
        {
            get { return estadoPrestamo; }
            set { estadoPrestamo = value; }
        }
        public Ejemplar EjemplarPrestado
        {
            get { return ejemplarPrestado; }
        }

        public Prestamo(Ejemplar ejemplarAPrestar, Socio socio)
        {
            ejemplarPrestado = ejemplarAPrestar;
            this.socio = socio;
            fechaPrestamo = DateTime.Now;
            estadoPrestamo = "PRESTADO";
        }
    }
}
