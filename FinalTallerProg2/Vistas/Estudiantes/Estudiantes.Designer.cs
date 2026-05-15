namespace FinalTallerProg2.Vistas.Estudiantes
{
    partial class Estudiantes
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
            this.btn_eliminar_estudiantes = new System.Windows.Forms.Button();
            this.btn_editar_estudiantes = new System.Windows.Forms.Button();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.btn_crear_estudiantes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.cb_campos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ep_categoria = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).BeginInit();
            this.SuspendLayout();
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
            this.btn_eliminar_estudiantes.Location = new System.Drawing.Point(521, 464);
            this.btn_eliminar_estudiantes.Name = "btn_eliminar_estudiantes";
            this.btn_eliminar_estudiantes.Size = new System.Drawing.Size(103, 38);
            this.btn_eliminar_estudiantes.TabIndex = 5;
            this.btn_eliminar_estudiantes.Text = "Eliminar";
            this.btn_eliminar_estudiantes.UseVisualStyleBackColor = false;
            this.btn_eliminar_estudiantes.Click += new System.EventHandler(this.btn_eliminar_estudiantes_Click);
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
            this.btn_editar_estudiantes.Location = new System.Drawing.Point(367, 464);
            this.btn_editar_estudiantes.Name = "btn_editar_estudiantes";
            this.btn_editar_estudiantes.Size = new System.Drawing.Size(103, 38);
            this.btn_editar_estudiantes.TabIndex = 4;
            this.btn_editar_estudiantes.Text = "Editar ";
            this.btn_editar_estudiantes.UseVisualStyleBackColor = false;
            this.btn_editar_estudiantes.Click += new System.EventHandler(this.btn_editar_estudiantes_Click);
            // 
            // dgv_estudiantes
            // 
            this.dgv_estudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiantes.Location = new System.Drawing.Point(12, 185);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.ReadOnly = true;
            this.dgv_estudiantes.Size = new System.Drawing.Size(643, 273);
            this.dgv_estudiantes.TabIndex = 3;
            this.dgv_estudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellClick);
            // 
            // btn_crear_estudiantes
            // 
            this.btn_crear_estudiantes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_estudiantes.Location = new System.Drawing.Point(16, 468);
            this.btn_crear_estudiantes.Name = "btn_crear_estudiantes";
            this.btn_crear_estudiantes.Size = new System.Drawing.Size(171, 34);
            this.btn_crear_estudiantes.TabIndex = 6;
            this.btn_crear_estudiantes.Text = "Cargar Alumno +";
            this.btn_crear_estudiantes.UseVisualStyleBackColor = false;
            this.btn_crear_estudiantes.Click += new System.EventHandler(this.btn_crear_estudiantes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(226, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestion de Alumnos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 79);
            this.panel2.TabIndex = 9;
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
            this.label1.Location = new System.Drawing.Point(245, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca IES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(50, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Buscar";
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(120, 142);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(200, 26);
            this.txt_buscador.TabIndex = 1;
            this.txt_buscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.cb_campos.Location = new System.Drawing.Point(338, 142);
            this.cb_campos.Name = "cb_campos";
            this.cb_campos.Size = new System.Drawing.Size(121, 26);
            this.cb_campos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(481, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Selecciona una Categoria";
            // 
            // ep_categoria
            // 
            this.ep_categoria.ContainerControl = this;
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(667, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_campos);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_eliminar_estudiantes);
            this.Controls.Add(this.btn_editar_estudiantes);
            this.Controls.Add(this.dgv_estudiantes);
            this.Controls.Add(this.btn_crear_estudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar_estudiantes;
        private System.Windows.Forms.Button btn_editar_estudiantes;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.Button btn_crear_estudiantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.ComboBox cb_campos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ep_categoria;
    }
}