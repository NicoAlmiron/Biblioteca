namespace FinalTallerProg2.Vistas.Inicio
{
    partial class EstudiantesInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(34, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Cantidad de Estudiantes Totales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Control de Estudiantes";
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.LightGreen;
            this.btn_estudiantes.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_estudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_estudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiantes.Location = new System.Drawing.Point(214, 358);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Size = new System.Drawing.Size(252, 47);
            this.btn_estudiantes.TabIndex = 3;
            this.btn_estudiantes.Text = "Administrador de Estudiantes";
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            this.btn_estudiantes.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Panel informativo de Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(35, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "- Carrera con mayor cantidad de estudiantes: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(35, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "- Carrera con menor cantidad de estudiantes: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(34, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "- Estudiantes con mayor edad: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(35, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "- Estudiantes con menor edad: ";
            // 
            // EstudiantesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 439);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_estudiantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstudiantesInfo";
            this.Text = "EstudiantesInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}