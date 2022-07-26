using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaQuark.Vista
{
    public interface IVista
    {
        //Campos
        //Socios
        string nombreSocioText { get; set; }
        string apellidoSocioText { get; set; }
        bool esVip { get; }
        string cuotaMensual { get; set; }

        //Libros
        string nombreLibroText { get; set; }
        string codigoISBNText { get; set; }
        string autorText { get; set; }

        //Ejemplares
        string[] listaTituloLibros { get; set; }
        string numeroEdicionText { get; set; }
        string ubicacionText { get; set; }


        //Prestamos
        string[] listaLibrosPrestamo { get; set; }
        string[] listaNombreSocios { get; set; }

        //PrestamosDevoluciones
        string nombreSocioDevoluciones { get; set; }
        string fechaDevoluciones { get; set; }
        string isbnPrestamo { get; set; }

        void MostrarMensaje(string v);
    }
}
