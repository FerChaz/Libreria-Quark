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

        public string CodigoISBN
        {
            get { return codigoISBN; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Autor
        {
            get { return autor; }
        }
        public int Ejemplares
        {
            get { return ejemplares.Count; }
        }

        private List<Ejemplar> ejemplares = new List<Ejemplar>();

        public Libro(string nombre, string isbn, string autor)
        {
            this.nombre = nombre;
            this.codigoISBN = isbn;
            this.autor = autor;
        }

        public void AgregarEjemplar(Ejemplar nuevoEjemplar)
        {
            this.ejemplares.Add(nuevoEjemplar);
        }

        public bool HayEjemplaresDisponibles()
        {
            return ejemplares.Count() >= 1 ? true : false; 
        }

        public Ejemplar PrestarEjemplar()
        {
            Ejemplar ejemplarAPrestar = ejemplares[ejemplares.Count - 1];
            ejemplares.Remove(ejemplarAPrestar);
            return ejemplarAPrestar;
        }

        public void ReponerEjemplar(Ejemplar ejemplarAReponer)
        {
            ejemplares.Add(ejemplarAReponer);
        }
    }
}
