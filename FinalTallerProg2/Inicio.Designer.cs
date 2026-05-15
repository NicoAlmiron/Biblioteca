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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(1, 1);
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
            this.panel1.Controls.Add(this.btn_alumno);
            this.panel1.Controls.Add(this.btn_prestamo);
            this.panel1.Controls.Add(this.btn_libros);
            this.panel1.Controls.Add(this.btn_autores);
            this.panel1.Location = new System.Drawing.Point(-4, 79);
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
            this.panel_general.Location = new System.Drawing.Point(216, 79);
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
            this.ClientSize = new System.Drawing.Size(734, 502);
            this.Controls.Add(this.panel_general);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca IES Yerba Buena";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

