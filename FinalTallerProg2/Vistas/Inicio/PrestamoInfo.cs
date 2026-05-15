using FinalTallerProg2.Vistas.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Vistas.Inicio
{
    public partial class PrestamoInfo : Form
    {
        public PrestamoInfo()
        {
            InitializeComponent();
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            PrestamosV prestamos = new PrestamosV();
            prestamos.Visible = true;
        }
    }
}
