namespace FinalTallerProg2.Vistas.Consultas
{
    partial class ConsultasV
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lst_consultas = new System.Windows.Forms.ListBox();
            this.txt_sql = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(10, 8);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(217, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Consultas";
            // 
            // lst_consultas
            // 
            this.lst_consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_consultas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_consultas.FormattingEnabled = true;
            this.lst_consultas.ItemHeight = 17;
            this.lst_consultas.Items.AddRange(new object[] {
            "1. Autores con mas de un libro publicado",
            "2. Nombre y edad de los estudiantes",
            "3. Estudiantes de la carrera de Informatica",
            "4. Estudiantes cuyo apellido empieza con G",
            "5. Autores del libro \"Visual Studio Net\"",
            "6. Autores de nacionalidad USA o Francia",
            "7. Libros que NO son del area Internet",
            "8. Libros que se presto Felipe Loayza Beramendi",
            "9. Estudiante de menor edad",
            "10. Estudiantes que se prestaron libros de Base de Datos",
            "11. Libros de la editorial Alfa y Omega",
            "12. Libros del autor Mario Benedetti",
            "13. Libros que debian devolverse el 10/04/07",
            "14. Suma de las edades de los estudiantes",
            "15. Estudiantes con edad mayor al promedio"});
            this.lst_consultas.Location = new System.Drawing.Point(12, 38);
            this.lst_consultas.Name = "lst_consultas";
            this.lst_consultas.Size = new System.Drawing.Size(479, 123);
            this.lst_consultas.TabIndex = 1;
            this.lst_consultas.SelectedIndexChanged += new System.EventHandler(this.lst_consultas_SelectedIndexChanged);
            // 
            // txt_sql
            // 
            this.txt_sql.Location = new System.Drawing.Point(12, 176);
            this.txt_sql.Multiline = true;
            this.txt_sql.Name = "txt_sql";
            this.txt_sql.ReadOnly = true;
            this.txt_sql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sql.Size = new System.Drawing.Size(479, 80);
            this.txt_sql.TabIndex = 2;
            this.txt_sql.TabStop = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(9, 259);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(236, 16);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Selecciona una consulta de la lista";
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            this.dgv_resultado.AllowUserToDeleteRows = false;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(12, 278);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.Size = new System.Drawing.Size(479, 131);
            this.dgv_resultado.TabIndex = 4;
            // 
            // ConsultasV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 419);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_sql);
            this.Controls.Add(this.lst_consultas);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultasV";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ConsultasV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ListBox lst_consultas;
        private System.Windows.Forms.TextBox txt_sql;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DataGridView dgv_resultado;
    }
}
