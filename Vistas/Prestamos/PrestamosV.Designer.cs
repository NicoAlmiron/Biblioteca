namespace FinalTallerProg2
{
    partial class PrestamosV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamosV));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.cms_prestamos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_devolver = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_crear_estudiantes = new System.Windows.Forms.Button();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.gb_buscarPor = new System.Windows.Forms.GroupBox();
            this.rb_estudiante = new System.Windows.Forms.RadioButton();
            this.rb_titulo = new System.Windows.Forms.RadioButton();
            this.chk_pendientes = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.cms_prestamos.SuspendLayout();
            this.gb_buscarPor.SuspendLayout();
            this.SuspendLayout();
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 79);
            this.panel2.TabIndex = 3;
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
            this.btn_volver.Location = new System.Drawing.Point(26, 25);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(86, 31);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "◄ Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(245, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca IES";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrador de Prestamos";
            //
            // dgv_prestamos
            //
            this.dgv_prestamos.AllowUserToDeleteRows = false;
            this.dgv_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestamos.ContextMenuStrip = this.cms_prestamos;
            this.dgv_prestamos.Location = new System.Drawing.Point(12, 186);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.ReadOnly = true;
            this.dgv_prestamos.Size = new System.Drawing.Size(662, 273);
            this.dgv_prestamos.TabIndex = 6;
            this.dgv_prestamos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_prestamos_CellMouseDown);
            //
            // cms_prestamos
            //
            this.cms_prestamos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_devolver});
            this.cms_prestamos.Name = "cms_prestamos";
            this.cms_prestamos.Size = new System.Drawing.Size(191, 26);
            this.cms_prestamos.Opening += new System.ComponentModel.CancelEventHandler(this.cms_prestamos_Opening);
            //
            // tsmi_devolver
            //
            this.tsmi_devolver.Name = "tsmi_devolver";
            this.tsmi_devolver.Size = new System.Drawing.Size(190, 22);
            this.tsmi_devolver.Text = "Marcar como devuelto";
            this.tsmi_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            //
            // btn_crear_estudiantes
            //
            this.btn_crear_estudiantes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_estudiantes.Location = new System.Drawing.Point(56, 481);
            this.btn_crear_estudiantes.Name = "btn_crear_estudiantes";
            this.btn_crear_estudiantes.Size = new System.Drawing.Size(181, 34);
            this.btn_crear_estudiantes.TabIndex = 11;
            this.btn_crear_estudiantes.Text = "Prestamo Nuevo +";
            this.btn_crear_estudiantes.UseVisualStyleBackColor = false;
            this.btn_crear_estudiantes.Click += new System.EventHandler(this.btn_crear_estudiantes_Click);
            //
            // txt_buscador
            //
            this.txt_buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(96, 140);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(200, 26);
            this.txt_buscador.TabIndex = 25;
            this.txt_buscador.TextChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(23, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Buscar";
            //
            // btn_devolver
            //
            this.btn_devolver.BackColor = System.Drawing.Color.Cyan;
            this.btn_devolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_devolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_devolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_devolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolver.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolver.Location = new System.Drawing.Point(523, 475);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(128, 47);
            this.btn_devolver.TabIndex = 29;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = false;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            //
            // gb_buscarPor
            //
            this.gb_buscarPor.Controls.Add(this.rb_estudiante);
            this.gb_buscarPor.Controls.Add(this.rb_titulo);
            this.gb_buscarPor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_buscarPor.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_buscarPor.Location = new System.Drawing.Point(312, 124);
            this.gb_buscarPor.Name = "gb_buscarPor";
            this.gb_buscarPor.Size = new System.Drawing.Size(196, 50);
            this.gb_buscarPor.TabIndex = 30;
            this.gb_buscarPor.TabStop = false;
            this.gb_buscarPor.Text = "Buscar por";
            //
            // rb_estudiante
            //
            this.rb_estudiante.AutoSize = true;
            this.rb_estudiante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_estudiante.Location = new System.Drawing.Point(88, 21);
            this.rb_estudiante.Name = "rb_estudiante";
            this.rb_estudiante.Size = new System.Drawing.Size(88, 20);
            this.rb_estudiante.TabIndex = 1;
            this.rb_estudiante.Text = "Estudiante";
            this.rb_estudiante.UseVisualStyleBackColor = true;
            this.rb_estudiante.CheckedChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // rb_titulo
            //
            this.rb_titulo.AutoSize = true;
            this.rb_titulo.Checked = true;
            this.rb_titulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_titulo.Location = new System.Drawing.Point(12, 21);
            this.rb_titulo.Name = "rb_titulo";
            this.rb_titulo.Size = new System.Drawing.Size(55, 20);
            this.rb_titulo.TabIndex = 0;
            this.rb_titulo.TabStop = true;
            this.rb_titulo.Text = "Libro";
            this.rb_titulo.UseVisualStyleBackColor = true;
            this.rb_titulo.CheckedChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // chk_pendientes
            //
            this.chk_pendientes.AutoSize = true;
            this.chk_pendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_pendientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_pendientes.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_pendientes.Location = new System.Drawing.Point(526, 143);
            this.chk_pendientes.Name = "chk_pendientes";
            this.chk_pendientes.Size = new System.Drawing.Size(140, 20);
            this.chk_pendientes.TabIndex = 31;
            this.chk_pendientes.Text = "Solo no devueltos";
            this.chk_pendientes.UseVisualStyleBackColor = true;
            this.chk_pendientes.CheckedChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // PrestamosV
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(688, 534);
            this.ControlBox = false;
            this.Controls.Add(this.chk_pendientes);
            this.Controls.Add(this.gb_buscarPor);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_crear_estudiantes);
            this.Controls.Add(this.dgv_prestamos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrestamosV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.cms_prestamos.ResumeLayout(false);
            this.gb_buscarPor.ResumeLayout(false);
            this.gb_buscarPor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.Button btn_crear_estudiantes;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.ContextMenuStrip cms_prestamos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_devolver;
        private System.Windows.Forms.GroupBox gb_buscarPor;
        private System.Windows.Forms.RadioButton rb_estudiante;
        private System.Windows.Forms.RadioButton rb_titulo;
        private System.Windows.Forms.CheckBox chk_pendientes;
    }
}
