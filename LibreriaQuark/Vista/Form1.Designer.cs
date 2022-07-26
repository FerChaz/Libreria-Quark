
namespace LibreriaQuark
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Libros = new System.Windows.Forms.TabPage();
            this.LimpiarInputsLibro = new System.Windows.Forms.Button();
            this.listaLibros = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.libroISBN = new System.Windows.Forms.TextBox();
            this.libroAutor = new System.Windows.Forms.TextBox();
            this.libroNombre = new System.Windows.Forms.TextBox();
            this.Ejemplares = new System.Windows.Forms.TabPage();
            this.limpiarEjemplar = new System.Windows.Forms.Button();
            this.AgregarEjemplar = new System.Windows.Forms.Button();
            this.ejemplarUbicacion = new System.Windows.Forms.TextBox();
            this.ejemplarEdicion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboLibros = new System.Windows.Forms.ComboBox();
            this.Socios = new System.Windows.Forms.TabPage();
            this.AgregarSocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.esVipCh = new System.Windows.Forms.CheckBox();
            this.socioCuotaMensual = new System.Windows.Forms.TextBox();
            this.apellidoSocio = new System.Windows.Forms.TextBox();
            this.nombreSocio = new System.Windows.Forms.TextBox();
            this.listaSocios = new System.Windows.Forms.DataGridView();
            this.Prestamos = new System.Windows.Forms.TabPage();
            this.LimpiarPrestamo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Prestar = new System.Windows.Forms.Button();
            this.comboSocioPrestamo = new System.Windows.Forms.ComboBox();
            this.comboLibroAPrestar = new System.Windows.Forms.ComboBox();
            this.listaHistorialPrestamos = new System.Windows.Forms.DataGridView();
            this.DevolverPrestamo = new System.Windows.Forms.TabPage();
            this.ISBNPrestamo = new System.Windows.Forms.Label();
            this.fechaPrestamo = new System.Windows.Forms.Label();
            this.nombreSocioPrestamo = new System.Windows.Forms.Label();
            this.Devolver = new System.Windows.Forms.Button();
            this.CancelarDevolucion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Libros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).BeginInit();
            this.Ejemplares.SuspendLayout();
            this.Socios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSocios)).BeginInit();
            this.Prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaHistorialPrestamos)).BeginInit();
            this.DevolverPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Libros);
            this.tabControl1.Controls.Add(this.Ejemplares);
            this.tabControl1.Controls.Add(this.Socios);
            this.tabControl1.Controls.Add(this.Prestamos);
            this.tabControl1.Controls.Add(this.DevolverPrestamo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Libros
            // 
            this.Libros.Controls.Add(this.LimpiarInputsLibro);
            this.Libros.Controls.Add(this.listaLibros);
            this.Libros.Controls.Add(this.label3);
            this.Libros.Controls.Add(this.label2);
            this.Libros.Controls.Add(this.label1);
            this.Libros.Controls.Add(this.Agregar);
            this.Libros.Controls.Add(this.libroISBN);
            this.Libros.Controls.Add(this.libroAutor);
            this.Libros.Controls.Add(this.libroNombre);
            this.Libros.Location = new System.Drawing.Point(4, 22);
            this.Libros.Name = "Libros";
            this.Libros.Padding = new System.Windows.Forms.Padding(3);
            this.Libros.Size = new System.Drawing.Size(792, 424);
            this.Libros.TabIndex = 0;
            this.Libros.Text = "Libros";
            this.Libros.UseVisualStyleBackColor = true;
            // 
            // LimpiarInputsLibro
            // 
            this.LimpiarInputsLibro.Location = new System.Drawing.Point(660, 214);
            this.LimpiarInputsLibro.Name = "LimpiarInputsLibro";
            this.LimpiarInputsLibro.Size = new System.Drawing.Size(75, 23);
            this.LimpiarInputsLibro.TabIndex = 9;
            this.LimpiarInputsLibro.Text = "Limpiar";
            this.LimpiarInputsLibro.UseVisualStyleBackColor = true;
            this.LimpiarInputsLibro.Click += new System.EventHandler(this.LimpiarInputsLibro_Click);
            // 
            // listaLibros
            // 
            this.listaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaLibros.Location = new System.Drawing.Point(8, 6);
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.Size = new System.Drawing.Size(535, 410);
            this.listaLibros.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Libro";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(578, 214);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.AgregarLibro_Click);
            // 
            // libroISBN
            // 
            this.libroISBN.Location = new System.Drawing.Point(563, 170);
            this.libroISBN.Name = "libroISBN";
            this.libroISBN.Size = new System.Drawing.Size(175, 20);
            this.libroISBN.TabIndex = 3;
            // 
            // libroAutor
            // 
            this.libroAutor.Location = new System.Drawing.Point(563, 120);
            this.libroAutor.Name = "libroAutor";
            this.libroAutor.Size = new System.Drawing.Size(175, 20);
            this.libroAutor.TabIndex = 2;
            // 
            // libroNombre
            // 
            this.libroNombre.Location = new System.Drawing.Point(563, 69);
            this.libroNombre.Name = "libroNombre";
            this.libroNombre.Size = new System.Drawing.Size(175, 20);
            this.libroNombre.TabIndex = 1;
            // 
            // Ejemplares
            // 
            this.Ejemplares.Controls.Add(this.limpiarEjemplar);
            this.Ejemplares.Controls.Add(this.AgregarEjemplar);
            this.Ejemplares.Controls.Add(this.ejemplarUbicacion);
            this.Ejemplares.Controls.Add(this.ejemplarEdicion);
            this.Ejemplares.Controls.Add(this.label9);
            this.Ejemplares.Controls.Add(this.label8);
            this.Ejemplares.Controls.Add(this.label7);
            this.Ejemplares.Controls.Add(this.comboLibros);
            this.Ejemplares.Location = new System.Drawing.Point(4, 22);
            this.Ejemplares.Name = "Ejemplares";
            this.Ejemplares.Size = new System.Drawing.Size(792, 424);
            this.Ejemplares.TabIndex = 2;
            this.Ejemplares.Text = "Ejemplares";
            this.Ejemplares.UseVisualStyleBackColor = true;
            // 
            // limpiarEjemplar
            // 
            this.limpiarEjemplar.Location = new System.Drawing.Point(302, 219);
            this.limpiarEjemplar.Name = "limpiarEjemplar";
            this.limpiarEjemplar.Size = new System.Drawing.Size(75, 23);
            this.limpiarEjemplar.TabIndex = 7;
            this.limpiarEjemplar.Text = "Limpiar";
            this.limpiarEjemplar.UseVisualStyleBackColor = true;
            // 
            // AgregarEjemplar
            // 
            this.AgregarEjemplar.Location = new System.Drawing.Point(164, 220);
            this.AgregarEjemplar.Name = "AgregarEjemplar";
            this.AgregarEjemplar.Size = new System.Drawing.Size(104, 23);
            this.AgregarEjemplar.TabIndex = 6;
            this.AgregarEjemplar.Text = "Agregar Ejemplar";
            this.AgregarEjemplar.UseVisualStyleBackColor = true;
            this.AgregarEjemplar.Click += new System.EventHandler(this.AgregarEjemplar_Click);
            // 
            // ejemplarUbicacion
            // 
            this.ejemplarUbicacion.Location = new System.Drawing.Point(278, 145);
            this.ejemplarUbicacion.Name = "ejemplarUbicacion";
            this.ejemplarUbicacion.Size = new System.Drawing.Size(100, 20);
            this.ejemplarUbicacion.TabIndex = 5;
            // 
            // ejemplarEdicion
            // 
            this.ejemplarEdicion.Location = new System.Drawing.Point(278, 99);
            this.ejemplarEdicion.Name = "ejemplarEdicion";
            this.ejemplarEdicion.Size = new System.Drawing.Size(100, 20);
            this.ejemplarEdicion.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ubicación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número de Edición";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Libro";
            // 
            // comboLibros
            // 
            this.comboLibros.FormattingEnabled = true;
            this.comboLibros.Location = new System.Drawing.Point(278, 51);
            this.comboLibros.Name = "comboLibros";
            this.comboLibros.Size = new System.Drawing.Size(121, 21);
            this.comboLibros.TabIndex = 0;
            // 
            // Socios
            // 
            this.Socios.Controls.Add(this.AgregarSocio);
            this.Socios.Controls.Add(this.label6);
            this.Socios.Controls.Add(this.label5);
            this.Socios.Controls.Add(this.label4);
            this.Socios.Controls.Add(this.esVipCh);
            this.Socios.Controls.Add(this.socioCuotaMensual);
            this.Socios.Controls.Add(this.apellidoSocio);
            this.Socios.Controls.Add(this.nombreSocio);
            this.Socios.Controls.Add(this.listaSocios);
            this.Socios.Location = new System.Drawing.Point(4, 22);
            this.Socios.Name = "Socios";
            this.Socios.Padding = new System.Windows.Forms.Padding(3);
            this.Socios.Size = new System.Drawing.Size(792, 424);
            this.Socios.TabIndex = 1;
            this.Socios.Text = "Socios";
            this.Socios.UseVisualStyleBackColor = true;
            // 
            // AgregarSocio
            // 
            this.AgregarSocio.Location = new System.Drawing.Point(546, 232);
            this.AgregarSocio.Name = "AgregarSocio";
            this.AgregarSocio.Size = new System.Drawing.Size(75, 23);
            this.AgregarSocio.TabIndex = 8;
            this.AgregarSocio.Text = "Agregar";
            this.AgregarSocio.UseVisualStyleBackColor = true;
            this.AgregarSocio.Click += new System.EventHandler(this.AgregarSocio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cuota Mensual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // esVipCh
            // 
            this.esVipCh.AutoSize = true;
            this.esVipCh.Location = new System.Drawing.Point(624, 141);
            this.esVipCh.Name = "esVipCh";
            this.esVipCh.Size = new System.Drawing.Size(86, 17);
            this.esVipCh.TabIndex = 4;
            this.esVipCh.Text = "Es Socio Vip";
            this.esVipCh.UseVisualStyleBackColor = true;
            this.esVipCh.CheckedChanged += new System.EventHandler(this.esVipCh_CheckedChanged);
            // 
            // socioCuotaMensual
            // 
            this.socioCuotaMensual.Enabled = false;
            this.socioCuotaMensual.Location = new System.Drawing.Point(624, 164);
            this.socioCuotaMensual.Name = "socioCuotaMensual";
            this.socioCuotaMensual.Size = new System.Drawing.Size(100, 20);
            this.socioCuotaMensual.TabIndex = 3;
            // 
            // apellidoSocio
            // 
            this.apellidoSocio.Location = new System.Drawing.Point(624, 100);
            this.apellidoSocio.Name = "apellidoSocio";
            this.apellidoSocio.Size = new System.Drawing.Size(100, 20);
            this.apellidoSocio.TabIndex = 2;
            // 
            // nombreSocio
            // 
            this.nombreSocio.Location = new System.Drawing.Point(624, 41);
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.Size = new System.Drawing.Size(100, 20);
            this.nombreSocio.TabIndex = 1;
            // 
            // listaSocios
            // 
            this.listaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSocios.Location = new System.Drawing.Point(8, 6);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(476, 410);
            this.listaSocios.TabIndex = 0;
            // 
            // Prestamos
            // 
            this.Prestamos.Controls.Add(this.LimpiarPrestamo);
            this.Prestamos.Controls.Add(this.label11);
            this.Prestamos.Controls.Add(this.label10);
            this.Prestamos.Controls.Add(this.Prestar);
            this.Prestamos.Controls.Add(this.comboSocioPrestamo);
            this.Prestamos.Controls.Add(this.comboLibroAPrestar);
            this.Prestamos.Controls.Add(this.listaHistorialPrestamos);
            this.Prestamos.Location = new System.Drawing.Point(4, 22);
            this.Prestamos.Name = "Prestamos";
            this.Prestamos.Size = new System.Drawing.Size(792, 424);
            this.Prestamos.TabIndex = 3;
            this.Prestamos.Text = "Prestamos";
            this.Prestamos.UseVisualStyleBackColor = true;
            // 
            // LimpiarPrestamo
            // 
            this.LimpiarPrestamo.Location = new System.Drawing.Point(668, 143);
            this.LimpiarPrestamo.Name = "LimpiarPrestamo";
            this.LimpiarPrestamo.Size = new System.Drawing.Size(107, 23);
            this.LimpiarPrestamo.TabIndex = 15;
            this.LimpiarPrestamo.Text = "Limpiar";
            this.LimpiarPrestamo.UseVisualStyleBackColor = true;
            this.LimpiarPrestamo.Click += new System.EventHandler(this.LimpiarPrestamo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(569, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Socio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Libro";
            // 
            // Prestar
            // 
            this.Prestar.Location = new System.Drawing.Point(555, 143);
            this.Prestar.Name = "Prestar";
            this.Prestar.Size = new System.Drawing.Size(107, 23);
            this.Prestar.TabIndex = 12;
            this.Prestar.Text = "Realizar Prestamo";
            this.Prestar.UseVisualStyleBackColor = true;
            this.Prestar.Click += new System.EventHandler(this.Prestar_Click);
            // 
            // comboSocioPrestamo
            // 
            this.comboSocioPrestamo.FormattingEnabled = true;
            this.comboSocioPrestamo.Location = new System.Drawing.Point(636, 90);
            this.comboSocioPrestamo.Name = "comboSocioPrestamo";
            this.comboSocioPrestamo.Size = new System.Drawing.Size(121, 21);
            this.comboSocioPrestamo.TabIndex = 11;
            // 
            // comboLibroAPrestar
            // 
            this.comboLibroAPrestar.FormattingEnabled = true;
            this.comboLibroAPrestar.Location = new System.Drawing.Point(636, 44);
            this.comboLibroAPrestar.Name = "comboLibroAPrestar";
            this.comboLibroAPrestar.Size = new System.Drawing.Size(121, 21);
            this.comboLibroAPrestar.TabIndex = 10;
            // 
            // listaHistorialPrestamos
            // 
            this.listaHistorialPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaHistorialPrestamos.Location = new System.Drawing.Point(8, 6);
            this.listaHistorialPrestamos.Name = "listaHistorialPrestamos";
            this.listaHistorialPrestamos.Size = new System.Drawing.Size(535, 410);
            this.listaHistorialPrestamos.TabIndex = 9;
            this.listaHistorialPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaHistorialPrestamos_CellContentClick);
            // 
            // DevolverPrestamo
            // 
            this.DevolverPrestamo.Controls.Add(this.CancelarDevolucion);
            this.DevolverPrestamo.Controls.Add(this.Devolver);
            this.DevolverPrestamo.Controls.Add(this.ISBNPrestamo);
            this.DevolverPrestamo.Controls.Add(this.fechaPrestamo);
            this.DevolverPrestamo.Controls.Add(this.nombreSocioPrestamo);
            this.DevolverPrestamo.Location = new System.Drawing.Point(4, 22);
            this.DevolverPrestamo.Name = "DevolverPrestamo";
            this.DevolverPrestamo.Size = new System.Drawing.Size(792, 424);
            this.DevolverPrestamo.TabIndex = 4;
            this.DevolverPrestamo.Text = "DevolverPrestamo";
            this.DevolverPrestamo.UseVisualStyleBackColor = true;
            // 
            // ISBNPrestamo
            // 
            this.ISBNPrestamo.AutoSize = true;
            this.ISBNPrestamo.Location = new System.Drawing.Point(243, 103);
            this.ISBNPrestamo.Name = "ISBNPrestamo";
            this.ISBNPrestamo.Size = new System.Drawing.Size(32, 13);
            this.ISBNPrestamo.TabIndex = 2;
            this.ISBNPrestamo.Text = "ISBN";
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.AutoSize = true;
            this.fechaPrestamo.Location = new System.Drawing.Point(243, 128);
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.Size = new System.Drawing.Size(99, 13);
            this.fechaPrestamo.TabIndex = 1;
            this.fechaPrestamo.Text = "Fecha de Prestamo";
            // 
            // nombreSocioPrestamo
            // 
            this.nombreSocioPrestamo.AutoSize = true;
            this.nombreSocioPrestamo.Location = new System.Drawing.Point(243, 78);
            this.nombreSocioPrestamo.Name = "nombreSocioPrestamo";
            this.nombreSocioPrestamo.Size = new System.Drawing.Size(74, 13);
            this.nombreSocioPrestamo.TabIndex = 0;
            this.nombreSocioPrestamo.Text = "Nombre Socio";
            // 
            // Devolver
            // 
            this.Devolver.Location = new System.Drawing.Point(246, 159);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(91, 23);
            this.Devolver.TabIndex = 3;
            this.Devolver.Text = "Devolver Libro";
            this.Devolver.UseVisualStyleBackColor = true;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // CancelarDevolucion
            // 
            this.CancelarDevolucion.Location = new System.Drawing.Point(358, 159);
            this.CancelarDevolucion.Name = "CancelarDevolucion";
            this.CancelarDevolucion.Size = new System.Drawing.Size(91, 23);
            this.CancelarDevolucion.TabIndex = 4;
            this.CancelarDevolucion.Text = "Cancelar";
            this.CancelarDevolucion.UseVisualStyleBackColor = true;
            this.CancelarDevolucion.Click += new System.EventHandler(this.CancelarDevolucion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.tabControl1.ResumeLayout(false);
            this.Libros.ResumeLayout(false);
            this.Libros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).EndInit();
            this.Ejemplares.ResumeLayout(false);
            this.Ejemplares.PerformLayout();
            this.Socios.ResumeLayout(false);
            this.Socios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSocios)).EndInit();
            this.Prestamos.ResumeLayout(false);
            this.Prestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaHistorialPrestamos)).EndInit();
            this.DevolverPrestamo.ResumeLayout(false);
            this.DevolverPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Libros;
        private System.Windows.Forms.TabPage Socios;
        private System.Windows.Forms.TextBox libroISBN;
        private System.Windows.Forms.TextBox libroAutor;
        private System.Windows.Forms.TextBox libroNombre;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaLibros;
        private System.Windows.Forms.Button LimpiarInputsLibro;
        private System.Windows.Forms.TextBox socioCuotaMensual;
        private System.Windows.Forms.TextBox apellidoSocio;
        private System.Windows.Forms.TextBox nombreSocio;
        private System.Windows.Forms.DataGridView listaSocios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox esVipCh;
        private System.Windows.Forms.Button AgregarSocio;
        private System.Windows.Forms.TabPage Ejemplares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboLibros;
        private System.Windows.Forms.Button limpiarEjemplar;
        private System.Windows.Forms.Button AgregarEjemplar;
        private System.Windows.Forms.TextBox ejemplarUbicacion;
        private System.Windows.Forms.TextBox ejemplarEdicion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage Prestamos;
        private System.Windows.Forms.Button LimpiarPrestamo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Prestar;
        private System.Windows.Forms.ComboBox comboSocioPrestamo;
        private System.Windows.Forms.ComboBox comboLibroAPrestar;
        private System.Windows.Forms.DataGridView listaHistorialPrestamos;
        private System.Windows.Forms.TabPage DevolverPrestamo;
        private System.Windows.Forms.Label ISBNPrestamo;
        private System.Windows.Forms.Label fechaPrestamo;
        private System.Windows.Forms.Label nombreSocioPrestamo;
        private System.Windows.Forms.Button CancelarDevolucion;
        private System.Windows.Forms.Button Devolver;
    }
}

