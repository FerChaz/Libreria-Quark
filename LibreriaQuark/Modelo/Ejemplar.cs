using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class Ejemplar
    {
        private int numeroEdicion;
        private string ubicacion;

        private string codigoISBNLibro;

        public string ISBN
        {
            get { return codigoISBNLibro; }
        }

        public Ejemplar(int numeroEdicion, string ubicacion, string isbn)
        {
            this.numeroEdicion = numeroEdicion;
            this.ubicacion = ubicacion;
            this.codigoISBNLibro = isbn;
        }
    }
}
