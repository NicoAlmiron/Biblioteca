namespace FinalTallerProg2.Vistas.Libros
{
    partial class EditarLibros
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
            this.cb_autor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editar_libro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ep_titulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_autor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_autor)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_autor
            // 
            this.cb_autor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_autor.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_autor.FormattingEnabled = true;
            this.cb_autor.Location = new System.Drawing.Point(293, 202);
            this.cb_autor.Name = "cb_autor";
            this.cb_autor.Size = new System.Drawing.Size(159, 26);
            this.cb_autor.TabIndex = 57;
            this.cb_autor.SelectedIndexChanged += new System.EventHandler(this.cb_autor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(289, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Autor";
            // 
            // btn_editar_libro
            // 
            this.btn_editar_libro.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_editar_libro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar_libro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_editar_libro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_editar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_libro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_libro.Location = new System.Drawing.Point(169, 260);
            this.btn_editar_libro.Name = "btn_editar_libro";
            this.btn_editar_libro.Size = new System.Drawing.Size(171, 34);
            this.btn_editar_libro.TabIndex = 58;
            this.btn_editar_libro.Text = "Editar Libro";
            this.btn_editar_libro.UseVisualStyleBackColor = false;
            this.btn_editar_libro.Click += new System.EventHandler(this.btn_editar_libro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 79);
            this.panel2.TabIndex = 62;
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
            this.btn_volver.Location = new System.Drawing.Point(26, 26);
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
            this.label1.Location = new System.Drawing.Point(161, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Libro";
            // 
            // txt_editorial
            // 
            this.txt_editorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editorial.Location = new System.Drawing.Point(28, 202);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(198, 26);
            this.txt_editorial.TabIndex = 56;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(28, 121);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(198, 26);
            this.txt_titulo.TabIndex = 54;
            this.txt_titulo.TextChanged += new System.EventHandler(this.txt_titulo_TextChanged);
            // 
            // txt_area
            // 
            this.txt_area.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.Location = new System.Drawing.Point(293, 121);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(159, 26);
            this.txt_area.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(24, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(289, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "Area";
            // 
            // ep_titulo
            // 
            this.ep_titulo.ContainerControl = this;
            // 
            // ep_autor
            // 
            this.ep_autor.ContainerControl = this;
            // 
            // EditarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(505, 324);
            this.ControlBox = false;
            this.Controls.Add(this.cb_autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_editar_libro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "EditarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarLibros";
            this.Load += new System.EventHandler(this.EditarLibros_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_autor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_autor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editar_libro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ep_titulo;
        private System.Windows.Forms.ErrorProvider ep_autor;
    }
}