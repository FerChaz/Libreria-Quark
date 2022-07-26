using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaQuark.Modelo
{
    class SocioVip : Socio
    {
        private float cuotaMensual;

        public SocioVip(string nombre, string apellido, float cuotaMensual, int id) : base (nombre, apellido, id)
        {
            this.cuotaMensual = cuotaMensual;
            this.esVip = true;
        }

        public override bool CupoDisponible()
        {
            return ejemplaresRetirados.Count == 3 ? false : true;
        }


    }
}
