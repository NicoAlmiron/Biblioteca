namespace FinalTallerProg2.Vistas.Prestamos
{
    partial class CrearPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_estudiante = new System.Windows.Forms.ComboBox();
            this.lb_estudiante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_libro = new System.Windows.Forms.ComboBox();
            this.cal_prestamo = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxt_fechaActual = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.btn_crear_prestamo = new System.Windows.Forms.Button();
            this.tb_nomEst = new System.Windows.Forms.TextBox();
            this.btn_nuevoEstudiante = new System.Windows.Forms.Button();
            this.tb_titLib = new System.Windows.Forms.TextBox();
            this.btn_nuevoLibro = new System.Windows.Forms.Button();
            this.ep_fechaHasta = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_crearPrestamo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_fechaInicial = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fechaHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_crearPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fechaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_volver.FlatAppearance.BorderSize = 2;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(11, 20);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(86, 31);
            this.btn_volver.TabIndex = 7;
            this.btn_volver.Text = "👈  Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo Nuevo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 79);
            this.panel2.TabIndex = 53;
            // 
            // cb_estudiante
            // 
            this.cb_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estudiante.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_estudiante.FormattingEnabled = true;
            this.cb_estudiante.Location = new System.Drawing.Point(229, 138);
            this.cb_estudiante.MaxDropDownItems = 99;
            this.cb_estudiante.Name = "cb_estudiante";
            this.cb_estudiante.Size = new System.Drawing.Size(205, 26);
            this.cb_estudiante.TabIndex = 54;
            this.cb_estudiante.SelectedIndexChanged += new System.EventHandler(this.cb_estudiante_SelectedIndexChanged);
            this.cb_estudiante.SelectionChangeCommitted += new System.EventHandler(this.cb_estudiante_SelectionChangeCommitted);
            this.cb_estudiante.TextChanged += new System.EventHandler(this.cb_estudiante_TextChanged);
            this.cb_estudiante.Click += new System.EventHandler(this.cb_estudiante_Click);
            // 
            // lb_estudiante
            // 
            this.lb_estudiante.AutoSize = true;
            this.lb_estudiante.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estudiante.Location = new System.Drawing.Point(7, 97);
            this.lb_estudiante.Name = "lb_estudiante";
            this.lb_estudiante.Size = new System.Drawing.Size(251, 27);
            this.lb_estudiante.TabIndex = 55;
            this.lb_estudiante.Text = "Nombre del Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Titulo del Libro";
            // 
            // cb_libro
            // 
            this.cb_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_libro.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_libro.FormattingEnabled = true;
            this.cb_libro.Location = new System.Drawing.Point(229, 222);
            this.cb_libro.Name = "cb_libro";
            this.cb_libro.Size = new System.Drawing.Size(205, 26);
            this.cb_libro.TabIndex = 56;
            this.cb_libro.SelectedIndexChanged += new System.EventHandler(this.cb_libro_SelectedIndexChanged);
            // 
            // cal_prestamo
            // 
            this.cal_prestamo.Location = new System.Drawing.Point(250, 320);
            this.cal_prestamo.MaxSelectionCount = 28;
            this.cal_prestamo.Name = "cal_prestamo";
            this.cal_prestamo.TabIndex = 58;
            this.cal_prestamo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_prestamo_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Hasta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(141, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "Fecha Del Prestamo";
            // 
            // mtxt_fechaActual
            // 
            this.mtxt_fechaActual.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxt_fechaActual.Location = new System.Drawing.Point(80, 344);
            this.mtxt_fechaActual.Mask = "00/00/0000";
            this.mtxt_fechaActual.Name = "mtxt_fechaActual";
            this.mtxt_fechaActual.Size = new System.Drawing.Size(89, 26);
            this.mtxt_fechaActual.TabIndex = 64;
            this.mtxt_fechaActual.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_fechaActual_MaskInputRejected);
            // 
            // mtxt_hasta
            // 
            this.mtxt_hasta.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxt_hasta.Location = new System.Drawing.Point(80, 440);
            this.mtxt_hasta.Mask = "00/00/0000";
            this.mtxt_hasta.Name = "mtxt_hasta";
            this.mtxt_hasta.Size = new System.Drawing.Size(89, 26);
            this.mtxt_hasta.TabIndex = 65;
            this.mtxt_hasta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_hasta_MaskInputRejected);
            this.mtxt_hasta.TextChanged += new System.EventHandler(this.mtxt_hasta_TextChanged);
            // 
            // btn_crear_prestamo
            // 
            this.btn_crear_prestamo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_prestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_prestamo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_prestamo.Location = new System.Drawing.Point(176, 505);
            this.btn_crear_prestamo.Name = "btn_crear_prestamo";
            this.btn_crear_prestamo.Size = new System.Drawing.Size(171, 34);
            this.btn_crear_prestamo.TabIndex = 66;
            this.btn_crear_prestamo.Text = "Crear Prestamo";
            this.btn_crear_prestamo.UseVisualStyleBackColor = false;
            this.btn_crear_prestamo.Click += new System.EventHandler(this.btn_crear_prestamo_Click);
            // 
            // tb_nomEst
            // 
            this.tb_nomEst.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_nomEst.Location = new System.Drawing.Point(12, 138);
            this.tb_nomEst.Name = "tb_nomEst";
            this.tb_nomEst.Size = new System.Drawing.Size(201, 26);
            this.tb_nomEst.TabIndex = 67;
            this.tb_nomEst.TextChanged += new System.EventHandler(this.tb_nomEst_TextChanged);
            // 
            // btn_nuevoEstudiante
            // 
            this.btn_nuevoEstudiante.BackColor = System.Drawing.Color.Cyan;
            this.btn_nuevoEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_nuevoEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_nuevoEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_nuevoEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoEstudiante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoEstudiante.Location = new System.Drawing.Point(457, 138);
            this.btn_nuevoEstudiante.Name = "btn_nuevoEstudiante";
            this.btn_nuevoEstudiante.Size = new System.Drawing.Size(89, 26);
            this.btn_nuevoEstudiante.TabIndex = 68;
            this.btn_nuevoEstudiante.Text = "Nuevo +";
            this.btn_nuevoEstudiante.UseVisualStyleBackColor = false;
            this.btn_nuevoEstudiante.Click += new System.EventHandler(this.btn_nuevoEstudiante_Click);
            // 
            // tb_titLib
            // 
            this.tb_titLib.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_titLib.Location = new System.Drawing.Point(12, 221);
            this.tb_titLib.Name = "tb_titLib";
            this.tb_titLib.Size = new System.Drawing.Size(201, 26);
            this.tb_titLib.TabIndex = 69;
            this.tb_titLib.TextChanged += new System.EventHandler(this.tb_titLib_TextChanged);
            // 
            // btn_nuevoLibro
            // 
            this.btn_nuevoLibro.BackColor = System.Drawing.Color.Cyan;
            this.btn_nuevoLibro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_nuevoLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_nuevoLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_nuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoLibro.Location = new System.Drawing.Point(457, 222);
            this.btn_nuevoLibro.Name = "btn_nuevoLibro";
            this.btn_nuevoLibro.Size = new System.Drawing.Size(89, 26);
            this.btn_nuevoLibro.TabIndex = 70;
            this.btn_nuevoLibro.Text = "Nuevo +";
            this.btn_nuevoLibro.UseVisualStyleBackColor = false;
            this.btn_nuevoLibro.Click += new System.EventHandler(this.btn_nuevoLibro_Click);
            // 
            // ep_fechaHasta
            // 
            this.ep_fechaHasta.ContainerControl = this;
            // 
            // ep_crearPrestamo
            // 
            this.ep_crearPrestamo.ContainerControl = this;
            // 
            // ep_fechaInicial
            // 
            this.ep_fechaInicial.ContainerControl = this;
            // 
            // CrearPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(558, 561);
            this.Controls.Add(this.btn_nuevoLibro);
            this.Controls.Add(this.tb_titLib);
            this.Controls.Add(this.btn_nuevoEstudiante);
            this.Controls.Add(this.tb_nomEst);
            this.Controls.Add(this.btn_crear_prestamo);
            this.Controls.Add(this.mtxt_hasta);
            this.Controls.Add(this.mtxt_fechaActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cal_prestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_libro);
            this.Controls.Add(this.lb_estudiante);
            this.Controls.Add(this.cb_estudiante);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "º";
            this.Load += new System.EventHandler(this.CrearPrestamo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fechaHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_crearPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fechaInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_estudiante;
        private System.Windows.Forms.Label lb_estudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_libro;
        private System.Windows.Forms.MonthCalendar cal_prestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxt_fechaActual;
        private System.Windows.Forms.MaskedTextBox mtxt_hasta;
        private System.Windows.Forms.Button btn_crear_prestamo;
        private System.Windows.Forms.TextBox tb_nomEst;
        private System.Windows.Forms.Button btn_nuevoEstudiante;
        private System.Windows.Forms.TextBox tb_titLib;
        private System.Windows.Forms.Button btn_nuevoLibro;
        private System.Windows.Forms.ErrorProvider ep_fechaHasta;
        private System.Windows.Forms.ErrorProvider ep_crearPrestamo;
        private System.Windows.Forms.ErrorProvider ep_fechaInicial;
    }
}