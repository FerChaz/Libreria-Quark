using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaQuark.Presentador;
using LibreriaQuark.Vista;

namespace LibreriaQuark
{
    public partial class Form1 : Form, IVista
    {
        BibliotecaPresentador presentador;
        
        public Form1()
        {
            presentador = new BibliotecaPresentador(this);
            InitializeComponent();
            tabControl1.TabPages[4].Enabled = false;
        }

        public string nombreSocioText 
        { 
            get { return nombreSocio.Text;  } 
            set { nombreSocio.Text = value; } 
        }
        public string apellidoSocioText 
        {
            get { return apellidoSocio.Text; }
            set { apellidoSocio.Text = value; }
        }
        public bool esVip 
        {
            get { return esVipCh.Checked; }
        }
        public string cuotaMensual 
        {
            get { return socioCuotaMensual.Text; }
            set { socioCuotaMensual.Text = value; }
        }


        public string nombreLibroText 
        {
            get { return libroNombre.Text; }
            set { libroNombre.Text = value; }
        }
        public string codigoISBNText 
        {
            get { return libroISBN.Text; }
            set { libroISBN.Text = value; }
        }
        public string autorText 
        {
            get { return libroAutor.Text; }
            set { libroAutor.Text = value; }
        }


        public string numeroEdicionText 
        {
            get { return ejemplarEdicion.Text; }
            set { ejemplarEdicion.Text = value; }
        }
        public string ubicacionText 
        {
            get { return ejemplarUbicacion.Text; }
            set { ejemplarUbicacion.Text = value; }
        }
        public string[] listaTituloLibros 
        { 
            get 
            {
                string[] items = new string[1];
                items[0] = comboLibros.Items[comboLibros.SelectedIndex].ToString();
                return items;
            }
            set
            {
                comboLibros.Items.Add(" ");
                string[] items = value;
                foreach (string item in items)
                {
                    comboLibros.Items.Add(item);
                }
            }
        }

        public string[] listaLibrosPrestamo 
        {
            get
            {
                string[] items = new string[1];
                items[0] = comboLibroAPrestar.Items[comboLibroAPrestar.SelectedIndex].ToString();
                return items;
            }
            set
            {
                comboLibroAPrestar.Items.Add(" ");
                string[] items = value;
                foreach (string item in items)
                {
                    comboLibroAPrestar.Items.Add(item);
                }
            }
        }
        public string[] listaNombreSocios 
        {
            get
            {
                string[] items = new string[1];
                items[0] = comboSocioPrestamo.Items[comboSocioPrestamo.SelectedIndex].ToString();
                return items;
            }
            set
            {
                comboSocioPrestamo.Items.Add(" ");
                string[] items = value;
                foreach (string item in items)
                {
                    comboSocioPrestamo.Items.Add(item);
                }
            }
        }

        public string nombreSocioDevoluciones 
        { 
            get { return nombreSocioPrestamo.Text; }
            set { nombreSocioPrestamo.Text = value; }
        }
        public string fechaDevoluciones 
        {
            get { return fechaPrestamo.Text; }
            set { fechaPrestamo.Text = value; }
        }
        public string isbnPrestamo
        {
            get { return ISBNPrestamo.Text; }
            set { ISBNPrestamo.Text = value; }
        }

        private void AgregarLibro_Click(object sender, EventArgs e)
        {
            presentador.AgregarLibro();
            ActualizarListaLibros();
            LimpiarInputsLibros();
        }
        private void LimpiarInputsLibro_Click(object sender, EventArgs e)
        {
            LimpiarInputsLibros();
        }

        private void ActualizarListaLibros()
        {
            listaLibros.DataSource = null;
            listaLibros.DataSource = presentador.RetornarListaLibros();
        }
        private void LimpiarInputsLibros()
        {
            nombreLibroText = null;
            codigoISBNText = null;
            autorText = null;

            libroNombre.Focus();
        }

        private void AgregarSocio_Click(object sender, EventArgs e)
        {
            presentador.AgregarSocio();
            ActualizarListaSocios();
            LimpiarInputsSocios();
        }

        private void ActualizarListaSocios()
        {
            listaSocios.DataSource = null;
            listaSocios.DataSource = presentador.RetornarListaSocios();
        }
        private void LimpiarInputsSocios()
        {
            nombreSocioText = null;
            apellidoSocioText = null;
            cuotaMensual = null;
            esVipCh.Checked = false;

            nombreSocio.Focus();
        }

        public void MostrarMensaje(string v)
        {
            MessageBox.Show(v);
        }

        private void esVipCh_CheckedChanged(object sender, EventArgs e)
        {
            if (esVipCh.Checked)
            {
                socioCuotaMensual.Enabled = true;
            } else
            {
                socioCuotaMensual.Enabled = false;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int selected = tabControl1.SelectedIndex;

            if (selected == 1)
            {
                comboLibros.Items.Clear();
                presentador.ActualizarListaTituloLibros();
                comboLibros.SelectedIndex = 0;
            }

            if (selected == 3)
            {
                comboLibroAPrestar.Items.Clear();
                presentador.ActualizarListaTituloLibrosAPrestar();
                comboSocioPrestamo.Items.Clear();
                presentador.ActualizarListaSociosPrestamo();

                comboLibroAPrestar.SelectedIndex = 0;
                comboSocioPrestamo.SelectedIndex = 0;
            }

            if (selected != 4)
            {
                tabControl1.TabPages[4].Enabled = false;
                LimpiarTabDevoluciones();
            }

        }

        private void AgregarEjemplar_Click(object sender, EventArgs e)
        {
            presentador.AgregarEjemplar();
            LimpiarInputsEjemplares();
        }
        private void LimpiarInputsEjemplares()
        {
            numeroEdicionText = null;
            ubicacionText = null;
            comboLibros.SelectedIndex = 0;
            ejemplarEdicion.Focus();
        }

        private void Prestar_Click(object sender, EventArgs e)
        {
            presentador.PrestarEjemplarLibro();
            ActualizarListaPrestamos();
            comboLibroAPrestar.SelectedIndex = 0;
            comboSocioPrestamo.SelectedIndex = 0;
        }
        private void ActualizarListaPrestamos()
        {
            listaHistorialPrestamos.DataSource = null;
            listaHistorialPrestamos.DataSource = presentador.RetornarListaPrestamos();
        }

        private void listaHistorialPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool estado = presentador.SetDevolucionTab(listaHistorialPrestamos.CurrentCell.RowIndex);
            if (!estado) return;
            tabControl1.TabPages[4].Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages[4];
        }
        private void LimpiarTabDevoluciones()
        {
            nombreSocioDevoluciones = "Nombre Socio";
            isbnPrestamo = "ISBN";
            fechaDevoluciones = "Fecha de Prestamo";
        }

        private void CancelarDevolucion_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[3];
            tabControl1.TabPages[4].Enabled = false;
            LimpiarTabDevoluciones();
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            presentador.DevolverEjemplarLibro();
            tabControl1.SelectedTab = tabControl1.TabPages[3];
            tabControl1.TabPages[4].Enabled = false;
            LimpiarTabDevoluciones();
        }

        private void LimpiarPrestamo_Click(object sender, EventArgs e)
        {
            comboLibroAPrestar.SelectedIndex = 0;
            comboSocioPrestamo.SelectedIndex = 0;
        }
    }
}
