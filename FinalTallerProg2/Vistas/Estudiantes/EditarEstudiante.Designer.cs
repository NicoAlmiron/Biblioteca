namespace FinalTallerProg2.Vistas.Estudiantes
{
    partial class EditarEstudiante
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
            this.btn_crear_estudiantes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_edadEst = new System.Windows.Forms.TextBox();
            this.txt_carrEst = new System.Windows.Forms.TextBox();
            this.txt_dirEst = new System.Windows.Forms.TextBox();
            this.txt_nomEst = new System.Windows.Forms.TextBox();
            this.txt_dniEst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ep_edad = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_nomEst = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_dniEst = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nomEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dniEst)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_estudiantes
            // 
            this.btn_crear_estudiantes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_crear_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_crear_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_crear_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_crear_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_estudiantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_estudiantes.Location = new System.Drawing.Point(145, 262);
            this.btn_crear_estudiantes.Name = "btn_crear_estudiantes";
            this.btn_crear_estudiantes.Size = new System.Drawing.Size(171, 34);
            this.btn_crear_estudiantes.TabIndex = 6;
            this.btn_crear_estudiantes.Text = "Cargar Estudiante";
            this.btn_crear_estudiantes.UseVisualStyleBackColor = false;
            this.btn_crear_estudiantes.Click += new System.EventHandler(this.btn_crear_estudiantes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 79);
            this.panel2.TabIndex = 52;
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
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Estudiante";
            // 
            // txt_edadEst
            // 
            this.txt_edadEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edadEst.Location = new System.Drawing.Point(184, 201);
            this.txt_edadEst.Name = "txt_edadEst";
            this.txt_edadEst.Size = new System.Drawing.Size(70, 26);
            this.txt_edadEst.TabIndex = 4;
            this.txt_edadEst.Text = "0";
            this.txt_edadEst.TextChanged += new System.EventHandler(this.txt_edadEst_TextChanged);
            // 
            // txt_carrEst
            // 
            this.txt_carrEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carrEst.Location = new System.Drawing.Point(278, 201);
            this.txt_carrEst.Name = "txt_carrEst";
            this.txt_carrEst.Size = new System.Drawing.Size(197, 26);
            this.txt_carrEst.TabIndex = 5;
            // 
            // txt_dirEst
            // 
            this.txt_dirEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dirEst.Location = new System.Drawing.Point(277, 124);
            this.txt_dirEst.Name = "txt_dirEst";
            this.txt_dirEst.Size = new System.Drawing.Size(198, 26);
            this.txt_dirEst.TabIndex = 2;
            // 
            // txt_nomEst
            // 
            this.txt_nomEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomEst.Location = new System.Drawing.Point(28, 124);
            this.txt_nomEst.Name = "txt_nomEst";
            this.txt_nomEst.Size = new System.Drawing.Size(198, 26);
            this.txt_nomEst.TabIndex = 1;
            this.txt_nomEst.TextChanged += new System.EventHandler(this.txt_nomEst_TextChanged);
            // 
            // txt_dniEst
            // 
            this.txt_dniEst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dniEst.Location = new System.Drawing.Point(28, 201);
            this.txt_dniEst.Name = "txt_dniEst";
            this.txt_dniEst.Size = new System.Drawing.Size(124, 26);
            this.txt_dniEst.TabIndex = 3;
            this.txt_dniEst.TextChanged += new System.EventHandler(this.txt_dniEst_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(180, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(274, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(273, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(24, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nombre Completo\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "DNI";
            // 
            // ep_edad
            // 
            this.ep_edad.ContainerControl = this;
            // 
            // ep_nomEst
            // 
            this.ep_nomEst.ContainerControl = this;
            // 
            // ep_dniEst
            // 
            this.ep_dniEst.ContainerControl = this;
            // 
            // EditarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(497, 336);
            this.ControlBox = false;
            this.Controls.Add(this.btn_crear_estudiantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_edadEst);
            this.Controls.Add(this.txt_carrEst);
            this.Controls.Add(this.txt_dirEst);
            this.Controls.Add(this.txt_nomEst);
            this.Controls.Add(this.txt_dniEst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEstudiante";
            this.Load += new System.EventHandler(this.EditarEstudiante_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nomEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dniEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_estudiantes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_edadEst;
        private System.Windows.Forms.TextBox txt_carrEst;
        private System.Windows.Forms.TextBox txt_dirEst;
        private System.Windows.Forms.TextBox txt_dniEst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_nomEst;
        private System.Windows.Forms.ErrorProvider ep_edad;
        private System.Windows.Forms.ErrorProvider ep_nomEst;
        private System.Windows.Forms.ErrorProvider ep_dniEst;
    }
}