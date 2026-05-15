namespace FinalTallerProg2.Vistas.Inicio
{
    partial class PrestamoInfo
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
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_prestamo.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prestamo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prestamo.Location = new System.Drawing.Point(347, 22);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(144, 58);
            this.btn_prestamo.TabIndex = 5;
            this.btn_prestamo.Text = "Administrador de Prestamos";
            this.btn_prestamo.UseVisualStyleBackColor = false;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Control de Prestamos";
            // 
            // PrestamoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 519);
            this.ControlBox = false;
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrestamoInfo";
            this.Text = "PrestamoInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Label label3;
    }
}