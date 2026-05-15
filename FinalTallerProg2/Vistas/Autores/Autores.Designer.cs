namespace FinalTallerProg2.Vistas.Autores
{
    partial class Autores
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
            this.dgv_autores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bucador_autor = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nombre_autor = new System.Windows.Forms.TextBox();
            this.tb_nacionalidad_autor = new System.Windows.Forms.TextBox();
            this.btn_crear_autor = new System.Windows.Forms.Button();
            this.btn_editar_autor = new System.Windows.Forms.Button();
            this.btn_eliminar_autor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ep_nomAut = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_categoria = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autores)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nomAut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_autores
            // 
            this.dgv_autores.AllowUserToDeleteRows = false;
            this.dgv_autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_autores.Location = new System.Drawing.Point(23, 181);
            this.dgv_autores.Name = "dgv_autores";
            this.dgv_autores.ReadOnly = true;
            this.dgv_autores.Size = new System.Drawing.Size(344, 209);
            this.dgv_autores.TabIndex = 17;
            this.dgv_autores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_autores_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Control de Autores";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 79);
            this.panel2.TabIndex = 20;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(445, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datos Autor";
            // 
            // tb_bucador_autor
            // 
            this.tb_bucador_autor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bucador_autor.Location = new System.Drawing.Point(82, 132);
            this.tb_bucador_autor.Name = "tb_bucador_autor";
            this.tb_bucador_autor.Size = new System.Drawing.Size(199, 26);
            this.tb_bucador_autor.TabIndex = 23;
            this.tb_bucador_autor.TextChanged += new System.EventHandler(this.tb_bucador_autor_TextChanged);
            // 
            // cb_categoria
            // 
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "IdAutor",
            "Nombre",
            "Nacionalidad"});
            this.cb_categoria.Location = new System.Drawing.Point(307, 133);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(476, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(460, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nacionalidad:";
            // 
            // tb_nombre_autor
            // 
            this.tb_nombre_autor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre_autor.Location = new System.Drawing.Point(413, 248);
            this.tb_nombre_autor.Name = "tb_nombre_autor";
            this.tb_nombre_autor.Size = new System.Drawing.Size(199, 26);
            this.tb_nombre_autor.TabIndex = 27;
            this.tb_nombre_autor.TextChanged += new System.EventHandler(this.tb_nombre_autor_TextChanged);
            // 
            // tb_nacionalidad_autor
            // 
            this.tb_nacionalidad_autor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nacionalidad_autor.Location = new System.Drawing.Point(413, 324);
            this.tb_nacionalidad_autor.Name = "tb_nacionalidad_autor";
            this.tb_nacionalidad_autor.Size = new System.Drawing.Size(199, 26);
            this.tb_nacionalidad_autor.TabIndex = 28;
            // 
            // btn_crear_autor
            // 
            this.btn_crear_autor.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_autor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_autor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_autor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_autor.Location = new System.Drawing.Point(425, 380);
            this.btn_crear_autor.Name = "btn_crear_autor";
            this.btn_crear_autor.Size = new System.Drawing.Size(171, 34);
            this.btn_crear_autor.TabIndex = 29;
            this.btn_crear_autor.Text = "Crear Autor +";
            this.btn_crear_autor.UseVisualStyleBackColor = false;
            this.btn_crear_autor.Click += new System.EventHandler(this.btn_crear_autor_Click);
            // 
            // btn_editar_autor
            // 
            this.btn_editar_autor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_autor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_autor.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar_autor.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar_autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_editar_autor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editar_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_autor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_autor.Location = new System.Drawing.Point(40, 410);
            this.btn_editar_autor.Name = "btn_editar_autor";
            this.btn_editar_autor.Size = new System.Drawing.Size(103, 38);
            this.btn_editar_autor.TabIndex = 30;
            this.btn_editar_autor.Text = "Editar ";
            this.btn_editar_autor.UseVisualStyleBackColor = false;
            this.btn_editar_autor.Click += new System.EventHandler(this.btn_editar_autor_Click);
            // 
            // btn_eliminar_autor
            // 
            this.btn_eliminar_autor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_eliminar_autor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_autor.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminar_autor.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_eliminar_autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btn_eliminar_autor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_autor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_autor.Location = new System.Drawing.Point(252, 410);
            this.btn_eliminar_autor.Name = "btn_eliminar_autor";
            this.btn_eliminar_autor.Size = new System.Drawing.Size(103, 38);
            this.btn_eliminar_autor.TabIndex = 31;
            this.btn_eliminar_autor.Text = "Eliminar";
            this.btn_eliminar_autor.UseVisualStyleBackColor = false;
            this.btn_eliminar_autor.Click += new System.EventHandler(this.btn_eliminar_autor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(460, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Selecciona una Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Buscar";
            // 
            // ep_nomAut
            // 
            this.ep_nomAut.ContainerControl = this;
            // 
            // ep_categoria
            // 
            this.ep_categoria.ContainerControl = this;
            // 
            // Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(646, 463);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_eliminar_autor);
            this.Controls.Add(this.btn_editar_autor);
            this.Controls.Add(this.btn_crear_autor);
            this.Controls.Add(this.tb_nacionalidad_autor);
            this.Controls.Add(this.tb_nombre_autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.tb_bucador_autor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_autores);
            this.Controls.Add(this.label2);
            this.Name = "Autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nomAut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_autores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bucador_autor;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nombre_autor;
        private System.Windows.Forms.TextBox tb_nacionalidad_autor;
        private System.Windows.Forms.Button btn_crear_autor;
        private System.Windows.Forms.Button btn_editar_autor;
        private System.Windows.Forms.Button btn_eliminar_autor;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider ep_nomAut;
        private System.Windows.Forms.ErrorProvider ep_categoria;
    }
}