namespace FinalTallerProg2.Vistas.Libros
{
    partial class Libros
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_libros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_campos = new System.Windows.Forms.ComboBox();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_editar_libro = new System.Windows.Forms.Button();
            this.btn_eliminar_libro = new System.Windows.Forms.Button();
            this.btn_crear_libro = new System.Windows.Forms.Button();
            this.ep_categoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 79);
            this.panel2.TabIndex = 26;
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
            this.btn_volver.Location = new System.Drawing.Point(23, 25);
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
            this.label1.Location = new System.Drawing.Point(222, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca IES";
            // 
            // dgv_libros
            // 
            this.dgv_libros.AllowUserToDeleteRows = false;
            this.dgv_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libros.Location = new System.Drawing.Point(38, 187);
            this.dgv_libros.Name = "dgv_libros";
            this.dgv_libros.ReadOnly = true;
            this.dgv_libros.Size = new System.Drawing.Size(543, 273);
            this.dgv_libros.TabIndex = 23;
            this.dgv_libros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libros_CellClick);
            this.dgv_libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libros_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gestion de Libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(427, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Selecciona una Categoria";
            // 
            // cb_campos
            // 
            this.cb_campos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_campos.FormattingEnabled = true;
            this.cb_campos.Items.AddRange(new object[] {
            "IdLibro",
            "Titulo",
            "Editorial",
            "Area",
            "Autor"});
            this.cb_campos.Location = new System.Drawing.Point(300, 141);
            this.cb_campos.Name = "cb_campos";
            this.cb_campos.Size = new System.Drawing.Size(121, 26);
            this.cb_campos.TabIndex = 28;
            this.cb_campos.SelectedIndexChanged += new System.EventHandler(this.cb_campos_SelectedIndexChanged);
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(82, 141);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(200, 26);
            this.txt_buscador.TabIndex = 27;
            this.txt_buscador.TextChanged += new System.EventHandler(this.txt_buscador_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Buscar";
            // 
            // btn_editar_libro
            // 
            this.btn_editar_libro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_libro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_libro.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar_libro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar_libro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_editar_libro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_libro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_libro.Location = new System.Drawing.Point(318, 471);
            this.btn_editar_libro.Name = "btn_editar_libro";
            this.btn_editar_libro.Size = new System.Drawing.Size(103, 38);
            this.btn_editar_libro.TabIndex = 31;
            this.btn_editar_libro.Text = "Editar ";
            this.btn_editar_libro.UseVisualStyleBackColor = false;
            this.btn_editar_libro.Click += new System.EventHandler(this.btn_editar_libro_Click);
            // 
            // btn_eliminar_libro
            // 
            this.btn_eliminar_libro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_eliminar_libro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_libro.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminar_libro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_eliminar_libro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_eliminar_libro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_libro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_libro.Location = new System.Drawing.Point(466, 471);
            this.btn_eliminar_libro.Name = "btn_eliminar_libro";
            this.btn_eliminar_libro.Size = new System.Drawing.Size(103, 38);
            this.btn_eliminar_libro.TabIndex = 32;
            this.btn_eliminar_libro.Text = "Eliminar";
            this.btn_eliminar_libro.UseVisualStyleBackColor = false;
            this.btn_eliminar_libro.Click += new System.EventHandler(this.btn_eliminar_libro_Click);
            // 
            // btn_crear_libro
            // 
            this.btn_crear_libro.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_libro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_libro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_libro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_libro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_libro.Location = new System.Drawing.Point(51, 473);
            this.btn_crear_libro.Name = "btn_crear_libro";
            this.btn_crear_libro.Size = new System.Drawing.Size(171, 34);
            this.btn_crear_libro.TabIndex = 33;
            this.btn_crear_libro.Text = "Cargar Libro +";
            this.btn_crear_libro.UseVisualStyleBackColor = false;
            this.btn_crear_libro.Click += new System.EventHandler(this.btn_crear_libro_Click);
            // 
            // ep_categoria
            // 
            this.ep_categoria.ContainerControl = this;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(619, 524);
            this.ControlBox = false;
            this.Controls.Add(this.btn_crear_libro);
            this.Controls.Add(this.btn_eliminar_libro);
            this.Controls.Add(this.btn_editar_libro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_campos);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_libros);
            this.Controls.Add(this.label2);
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_libros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_campos;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_editar_libro;
        private System.Windows.Forms.Button btn_eliminar_libro;
        private System.Windows.Forms.Button btn_crear_libro;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ErrorProvider ep_categoria;
    }
}