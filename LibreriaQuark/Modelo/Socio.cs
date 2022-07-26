using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class Socio
    {
        protected string nombre;
        protected string apellido;
        protected int numeroID;

        protected bool esVip;

        public string NombreApellido
        {
            get { return nombre + " " + apellido; }
        }
        public bool EsVip
        {
            get { return esVip; }
        }

        protected List<Ejemplar> ejemplaresRetirados = new List<Ejemplar>();

        public Socio(string nombre, string apellido, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;

            this.numeroID = id;
        }

        public virtual bool CupoDisponible()
        {
            return ejemplaresRetirados.Count == 1 ? false : true;
        }

        public void PedirEjemplar(Ejemplar ejemplarPedido)
        {
            ejemplaresRetirados.Add(ejemplarPedido);
        }

        public void DevolverEjemplar(Ejemplar ejemplarADevolver)
        {
            ejemplaresRetirados.Remove(ejemplarADevolver);
        }
    }
}
