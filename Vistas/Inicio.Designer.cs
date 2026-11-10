namespace FinalTallerProg2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.btn_autores = new System.Windows.Forms.Button();
            this.btn_libros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alumno = new System.Windows.Forms.Button();
            this.panel_general = new System.Windows.Forms.Panel();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.tsmi_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_listaPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_nuevoPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_separador = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_admLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_admAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_admEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ms_principal.SuspendLayout();
            this.SuspendLayout();
            //
            // ms_principal
            //
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ver,
            this.tsmi_administrar,
            this.tsmi_salir});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Size = new System.Drawing.Size(734, 24);
            this.ms_principal.TabIndex = 13;
            this.ms_principal.Text = "menuStrip1";
            //
            // tsmi_ver
            //
            this.tsmi_ver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verPrestamos,
            this.tsmi_verEstudiantes,
            this.tsmi_verAutores,
            this.tsmi_verLibros,
            this.tsmi_verConsultas});
            this.tsmi_ver.Name = "tsmi_ver";
            this.tsmi_ver.Size = new System.Drawing.Size(40, 20);
            this.tsmi_ver.Text = "Ver";
            //
            // tsmi_verPrestamos
            //
            this.tsmi_verPrestamos.Name = "tsmi_verPrestamos";
            this.tsmi_verPrestamos.Size = new System.Drawing.Size(220, 22);
            this.tsmi_verPrestamos.Text = "Resumen de Prestamos";
            this.tsmi_verPrestamos.Click += new System.EventHandler(this.btn_prestamo_Click);
            //
            // tsmi_verEstudiantes
            //
            this.tsmi_verEstudiantes.Name = "tsmi_verEstudiantes";
            this.tsmi_verEstudiantes.Size = new System.Drawing.Size(220, 22);
            this.tsmi_verEstudiantes.Text = "Resumen de Estudiantes";
            this.tsmi_verEstudiantes.Click += new System.EventHandler(this.btn_alumno_Click);
            //
            // tsmi_verAutores
            //
            this.tsmi_verAutores.Name = "tsmi_verAutores";
            this.tsmi_verAutores.Size = new System.Drawing.Size(220, 22);
            this.tsmi_verAutores.Text = "Resumen de Autores";
            this.tsmi_verAutores.Click += new System.EventHandler(this.btn_autores_Click);
            //
            // tsmi_verLibros
            //
            this.tsmi_verLibros.Name = "tsmi_verLibros";
            this.tsmi_verLibros.Size = new System.Drawing.Size(220, 22);
            this.tsmi_verLibros.Text = "Resumen de Libros";
            this.tsmi_verLibros.Click += new System.EventHandler(this.btn_libros_Click);
            //
            // tsmi_verConsultas
            //
            this.tsmi_verConsultas.Name = "tsmi_verConsultas";
            this.tsmi_verConsultas.Size = new System.Drawing.Size(220, 22);
            this.tsmi_verConsultas.Text = "Consultas";
            this.tsmi_verConsultas.Click += new System.EventHandler(this.btn_consultas_Click);
            //
            // tsmi_administrar
            //
            this.tsmi_administrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_listaPrestamos,
            this.tsmi_nuevoPrestamo,
            this.tss_separador,
            this.tsmi_admLibros,
            this.tsmi_admAutores,
            this.tsmi_admEstudiantes});
            this.tsmi_administrar.Name = "tsmi_administrar";
            this.tsmi_administrar.Size = new System.Drawing.Size(85, 20);
            this.tsmi_administrar.Text = "Administrar";
            //
            // tsmi_listaPrestamos
            //
            this.tsmi_listaPrestamos.Name = "tsmi_listaPrestamos";
            this.tsmi_listaPrestamos.Size = new System.Drawing.Size(200, 22);
            this.tsmi_listaPrestamos.Text = "Lista de Prestamos";
            this.tsmi_listaPrestamos.Click += new System.EventHandler(this.tsmi_listaPrestamos_Click);
            //
            // tsmi_nuevoPrestamo
            //
            this.tsmi_nuevoPrestamo.Name = "tsmi_nuevoPrestamo";
            this.tsmi_nuevoPrestamo.Size = new System.Drawing.Size(200, 22);
            this.tsmi_nuevoPrestamo.Text = "Nuevo Prestamo";
            this.tsmi_nuevoPrestamo.Click += new System.EventHandler(this.tsmi_nuevoPrestamo_Click);
            //
            // tss_separador
            //
            this.tss_separador.Name = "tss_separador";
            this.tss_separador.Size = new System.Drawing.Size(197, 6);
            //
            // tsmi_admLibros
            //
            this.tsmi_admLibros.Name = "tsmi_admLibros";
            this.tsmi_admLibros.Size = new System.Drawing.Size(200, 22);
            this.tsmi_admLibros.Text = "Libros";
            this.tsmi_admLibros.Click += new System.EventHandler(this.tsmi_admLibros_Click);
            //
            // tsmi_admAutores
            //
            this.tsmi_admAutores.Name = "tsmi_admAutores";
            this.tsmi_admAutores.Size = new System.Drawing.Size(200, 22);
            this.tsmi_admAutores.Text = "Autores";
            this.tsmi_admAutores.Click += new System.EventHandler(this.tsmi_admAutores_Click);
            //
            // tsmi_admEstudiantes
            //
            this.tsmi_admEstudiantes.Name = "tsmi_admEstudiantes";
            this.tsmi_admEstudiantes.Size = new System.Drawing.Size(200, 22);
            this.tsmi_admEstudiantes.Text = "Estudiantes";
            this.tsmi_admEstudiantes.Click += new System.EventHandler(this.tsmi_admEstudiantes_Click);
            //
            // tsmi_salir
            //
            this.tsmi_salir.Name = "tsmi_salir";
            this.tsmi_salir.Size = new System.Drawing.Size(42, 20);
            this.tsmi_salir.Text = "Salir";
            this.tsmi_salir.Click += new System.EventHandler(this.tsmi_salir_Click);
            //
            // btn_consultas
            //
            this.btn_consultas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_consultas.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.Location = new System.Drawing.Point(3, 305);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(220, 58);
            this.btn_consultas.TabIndex = 13;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca IES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 79);
            this.panel2.TabIndex = 2;
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_prestamo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_prestamo.FlatAppearance.BorderSize = 0;
            this.btn_prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prestamo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prestamo.Location = new System.Drawing.Point(3, 49);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(220, 58);
            this.btn_prestamo.TabIndex = 3;
            this.btn_prestamo.Text = "Prestamos";
            this.btn_prestamo.UseVisualStyleBackColor = false;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // btn_autores
            // 
            this.btn_autores.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_autores.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_autores.FlatAppearance.BorderSize = 0;
            this.btn_autores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_autores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_autores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autores.Location = new System.Drawing.Point(3, 177);
            this.btn_autores.Name = "btn_autores";
            this.btn_autores.Size = new System.Drawing.Size(220, 58);
            this.btn_autores.TabIndex = 8;
            this.btn_autores.Text = "Autores";
            this.btn_autores.UseVisualStyleBackColor = false;
            this.btn_autores.Click += new System.EventHandler(this.btn_autores_Click);
            // 
            // btn_libros
            // 
            this.btn_libros.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_libros.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_libros.FlatAppearance.BorderSize = 0;
            this.btn_libros.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_libros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_libros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_libros.Location = new System.Drawing.Point(3, 241);
            this.btn_libros.Name = "btn_libros";
            this.btn_libros.Size = new System.Drawing.Size(220, 58);
            this.btn_libros.TabIndex = 10;
            this.btn_libros.Text = "Libros";
            this.btn_libros.UseVisualStyleBackColor = false;
            this.btn_libros.Click += new System.EventHandler(this.btn_libros_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_consultas);
            this.panel1.Controls.Add(this.btn_alumno);
            this.panel1.Controls.Add(this.btn_prestamo);
            this.panel1.Controls.Add(this.btn_libros);
            this.panel1.Controls.Add(this.btn_autores);
            this.panel1.Location = new System.Drawing.Point(-4, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 422);
            this.panel1.TabIndex = 11;
            // 
            // btn_alumno
            // 
            this.btn_alumno.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_alumno.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_alumno.FlatAppearance.BorderSize = 0;
            this.btn_alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_alumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumno.Location = new System.Drawing.Point(3, 113);
            this.btn_alumno.Name = "btn_alumno";
            this.btn_alumno.Size = new System.Drawing.Size(220, 58);
            this.btn_alumno.TabIndex = 12;
            this.btn_alumno.Text = "Estudiantes";
            this.btn_alumno.UseVisualStyleBackColor = false;
            this.btn_alumno.Click += new System.EventHandler(this.btn_alumno_Click);
            // 
            // panel_general
            // 
            this.panel_general.AutoScroll = true;
            this.panel_general.Location = new System.Drawing.Point(216, 103);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(519, 422);
            this.panel_general.TabIndex = 12;
            this.panel_general.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_general_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(734, 526);
            this.Controls.Add(this.panel_general);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ms_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_principal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca IES Yerba Buena";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Button btn_autores;
        private System.Windows.Forms.Button btn_libros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.Button btn_alumno;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ver;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verPrestamos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verAutores;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verLibros;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_administrar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_listaPrestamos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_nuevoPrestamo;
        private System.Windows.Forms.ToolStripSeparator tss_separador;
        private System.Windows.Forms.ToolStripMenuItem tsmi_admLibros;
        private System.Windows.Forms.ToolStripMenuItem tsmi_admAutores;
        private System.Windows.Forms.ToolStripMenuItem tsmi_admEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_salir;
    }
}

