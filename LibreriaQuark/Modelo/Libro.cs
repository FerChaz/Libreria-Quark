using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class Libro
    {
        private string nombre;
        private string codigoISBN;
        private string autor;

        private List<Ejemplar> ejemplares = new List<Ejemplar>();
    }
}
