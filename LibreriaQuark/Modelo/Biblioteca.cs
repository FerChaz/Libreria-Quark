using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class Biblioteca
    {
        private List<Socio> socios = new List<Socio>();
        private List<Libro> libros = new List<Libro>();
        private List<Prestamo> prestamos = new List<Prestamo>();

        public List<Libro> _libros 
        {
            get { return libros; }
        }
        public List<Socio> _socios
        {
            get { return socios; }
        }
        public List<Prestamo> _prestamos
        {
            get { return prestamos; }
        }

        public void AgregarLibro(Libro nuevoLibro)
        {
            libros.Add(nuevoLibro);
        }

        public int CantidadSocios()
        {
            return socios.Count();
        }

        public void AgregarSocio(Socio nuevoSocio)
        {
            socios.Add(nuevoSocio);
        }

        public void AgregarPrestamo(Prestamo nuevoPrestamo)
        {
            prestamos.Add(nuevoPrestamo);
        }
    }
}
