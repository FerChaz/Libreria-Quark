using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaQuark.Modelo;
using LibreriaQuark.Vista;

namespace LibreriaQuark.Presentador
{
    class BibliotecaPresentador
    {
        Biblioteca biblioteca;
        IVista vista;

        public BibliotecaPresentador(IVista vista)
        {
            this.vista = vista;
            this.biblioteca = new Biblioteca();
        }

        public void AgregarLibro()
        {
            if (vista.nombreLibroText == null || vista.nombreLibroText == "")
            {
                vista.MostrarMensaje("Debe colocar el Título del libro.");
                return;
            }
            if (vista.codigoISBNText == null || vista.codigoISBNText == "")
            {
                vista.MostrarMensaje("Debe colocar el Código ISBN del libro.");
                return;
            }
            if (vista.autorText == null || vista.autorText == "")
            {
                vista.MostrarMensaje("Debe colocar el Autor del libro.");
                return;
            }
            Libro nuevoLibro = new Libro(vista.nombreLibroText, vista.codigoISBNText, vista.autorText);
            biblioteca.AgregarLibro(nuevoLibro);
        }

        public List<Libro> RetornarListaLibros()
        {
            return biblioteca._libros;
        }
        public List<Socio> RetornarListaSocios()
        {
            return biblioteca._socios;
        }
        public List<Prestamo> RetornarListaPrestamos()
        {
            return biblioteca._prestamos;
        }

        public void AgregarSocio()
        {
            if (vista.nombreSocioText == null || vista.nombreSocioText == "")
            {
                vista.MostrarMensaje("Debe colocar el nombre del socio.");
                return;
            }
            if (vista.apellidoSocioText == null || vista.apellidoSocioText == "")
            {
                vista.MostrarMensaje("Debe colocar el apellido del socio.");
                return;
            }

            if (vista.esVip)
            {
                float cuotaMensual;
                try
                {
                    cuotaMensual = float.Parse(vista.cuotaMensual);
                }
                catch
                {
                    vista.MostrarMensaje("El valor de cuota mensual debe ser un número válido.");
                    return;
                }
                
                SocioVip nuevoSocio = new SocioVip(vista.nombreSocioText, vista.apellidoSocioText, cuotaMensual, biblioteca.CantidadSocios() + 1);
                biblioteca.AgregarSocio(nuevoSocio);
            }
            else
            {
                Socio nuevoSocio = new Socio(vista.nombreSocioText, vista.apellidoSocioText, biblioteca.CantidadSocios() + 1);
                biblioteca.AgregarSocio(nuevoSocio);
            }
        }

        public void ActualizarListaTituloLibros()
        {
            string[] libros = new string[biblioteca._libros.Count];
            for (int i = 0; i < libros.Length; i++)
            {
                libros[i] = biblioteca._libros.ElementAt(i).Nombre;
            }

            vista.listaTituloLibros = libros;
        }

        public void AgregarEjemplar()
        {
            Libro libro = biblioteca._libros.Find(L => L.Nombre == vista.listaTituloLibros[0]);
            if (libro == null)
            {
                vista.MostrarMensaje("Debe seleccionar un libro válido.");
                return;
            }
            if (vista.ubicacionText == null || vista.ubicacionText == "")
            {
                vista.MostrarMensaje("Debe colocar la ubicación del ejemplar.");
                return;
            }
            if (vista.ubicacionText == null || vista.ubicacionText == "")
            {
                vista.MostrarMensaje("Debe colocar la ubicación del ejemplar.");
                return;
            }
            int numeroEdicion; 
            try
            {
                numeroEdicion = int.Parse(vista.numeroEdicionText);
            }
            catch
            {
                vista.MostrarMensaje("El número de edición debe ser un número válido.");
                return;
            }

            
            Ejemplar nuevoEjemplar = new Ejemplar(numeroEdicion, vista.ubicacionText, libro.CodigoISBN);

            libro.AgregarEjemplar(nuevoEjemplar);

            vista.MostrarMensaje("El ejemplar fue agregado exitósamente.");
        }

        public void ActualizarListaTituloLibrosAPrestar()
        {
            string[] libros = new string[biblioteca._libros.Count];
            for (int i = 0; i < libros.Length; i++)
            {
                libros[i] = biblioteca._libros.ElementAt(i).Nombre;
            }

            vista.listaLibrosPrestamo = libros;
        }

        public void ActualizarListaSociosPrestamo()
        {
            string[] socios = new string[biblioteca._socios.Count];
            for (int i = 0; i < socios.Length; i++)
            {
                socios[i] = biblioteca._socios.ElementAt(i).NombreApellido;
            }

            vista.listaNombreSocios = socios;
        }

        public void PrestarEjemplarLibro()
        {
            Libro libro = biblioteca._libros.Find(L => L.Nombre == vista.listaLibrosPrestamo[0]);
            if (libro == null)
            {
                vista.MostrarMensaje("Debe seleccionar un libro válido.");
                return;
            }
            if (!libro.HayEjemplaresDisponibles())
            {
                vista.MostrarMensaje("El libro seleccionado no posee ejemplares disponibles.");
                return;
            }
            Socio socio = biblioteca._socios.Find(S => S.NombreApellido == vista.listaNombreSocios[0]);
            if (socio == null)
            {
                vista.MostrarMensaje("Debe seleccionar un socio válido.");
                return;
            }

            if (socio.CupoDisponible())
            {
                Ejemplar ejemplarAPrestar = libro.PrestarEjemplar();
                Prestamo nuevoPrestamo = new Prestamo(ejemplarAPrestar, socio);
                biblioteca.AgregarPrestamo(nuevoPrestamo);
                socio.PedirEjemplar(ejemplarAPrestar);
                vista.MostrarMensaje("El ejemplar fue prestado exitósamente a " + socio.NombreApellido + ".");
            }
            else
            {
                vista.MostrarMensaje("El socio seleccionado no tiene cupo disponible.");
                return;
            }

        }

        public bool SetDevolucionTab(int indexListaPrestamos)
        {
            Prestamo currentPrestamo = biblioteca._prestamos[indexListaPrestamos];
            if(currentPrestamo.EstadoPrestamo != "PRESTADO")
            {
                return false;
            }
            vista.nombreSocioDevoluciones = currentPrestamo.NombreSocio;
            vista.isbnPrestamo = currentPrestamo.ISBN;
            vista.fechaDevoluciones = currentPrestamo.FechaPrestamo;
            return true;
        }

        public void DevolverEjemplarLibro()
        {
            Prestamo prestamo = biblioteca._prestamos.Find(P => P.NombreSocio == vista.nombreSocioDevoluciones && P.FechaPrestamo == vista.fechaDevoluciones);
            Libro libro = biblioteca._libros.Find(L => L.CodigoISBN == vista.isbnPrestamo);
            Socio socio = biblioteca._socios.Find(S => S.NombreApellido == vista.nombreSocioDevoluciones);

            libro.ReponerEjemplar(prestamo.EjemplarPrestado);
            socio.DevolverEjemplar(prestamo.EjemplarPrestado);
            prestamo.EstadoPrestamo = "DEVUELTO";
        }
    }
}
