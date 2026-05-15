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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamosV));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.btn_eliminar_estudiantes = new System.Windows.Forms.Button();
            this.btn_editar_estudiantes = new System.Windows.Forms.Button();
            this.btn_crear_estudiantes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_campos = new System.Windows.Forms.ComboBox();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
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
            this.btn_volver.Text = "👈  Volver";
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
            this.dgv_prestamos.Location = new System.Drawing.Point(12, 176);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.ReadOnly = true;
            this.dgv_prestamos.Size = new System.Drawing.Size(662, 273);
            this.dgv_prestamos.TabIndex = 6;
            // 
            // btn_eliminar_estudiantes
            // 
            this.btn_eliminar_estudiantes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_eliminar_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminar_estudiantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_eliminar_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_eliminar_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_estudiantes.Location = new System.Drawing.Point(398, 462);
            this.btn_eliminar_estudiantes.Name = "btn_eliminar_estudiantes";
            this.btn_eliminar_estudiantes.Size = new System.Drawing.Size(103, 38);
            this.btn_eliminar_estudiantes.TabIndex = 10;
            this.btn_eliminar_estudiantes.Text = "Eliminar";
            this.btn_eliminar_estudiantes.UseVisualStyleBackColor = false;
            // 
            // btn_editar_estudiantes
            // 
            this.btn_editar_estudiantes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar_estudiantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_editar_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editar_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_estudiantes.Location = new System.Drawing.Point(244, 462);
            this.btn_editar_estudiantes.Name = "btn_editar_estudiantes";
            this.btn_editar_estudiantes.Size = new System.Drawing.Size(103, 38);
            this.btn_editar_estudiantes.TabIndex = 9;
            this.btn_editar_estudiantes.Text = "Editar ";
            this.btn_editar_estudiantes.UseVisualStyleBackColor = false;
            // 
            // btn_crear_estudiantes
            // 
            this.btn_crear_estudiantes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_estudiantes.Location = new System.Drawing.Point(12, 466);
            this.btn_crear_estudiantes.Name = "btn_crear_estudiantes";
            this.btn_crear_estudiantes.Size = new System.Drawing.Size(181, 34);
            this.btn_crear_estudiantes.TabIndex = 11;
            this.btn_crear_estudiantes.Text = "Prestamo Nuevo +";
            this.btn_crear_estudiantes.UseVisualStyleBackColor = false;
            this.btn_crear_estudiantes.Click += new System.EventHandler(this.btn_crear_estudiantes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(467, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Selecciona una Categoria";
            // 
            // cb_campos
            // 
            this.cb_campos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_campos.FormattingEnabled = true;
            this.cb_campos.Items.AddRange(new object[] {
            "Carrera",
            "DNI",
            "Edad",
            "IdEstudiante",
            "Nombre"});
            this.cb_campos.Location = new System.Drawing.Point(324, 134);
            this.cb_campos.Name = "cb_campos";
            this.cb_campos.Size = new System.Drawing.Size(121, 26);
            this.cb_campos.TabIndex = 26;
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(106, 134);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(200, 26);
            this.txt_buscador.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(36, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(523, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PrestamosV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(688, 514);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_campos);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_eliminar_estudiantes);
            this.Controls.Add(this.btn_editar_estudiantes);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.Button btn_eliminar_estudiantes;
        private System.Windows.Forms.Button btn_editar_estudiantes;
        private System.Windows.Forms.Button btn_crear_estudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_campos;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button button1;
    }
}