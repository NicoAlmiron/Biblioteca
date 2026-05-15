using FinalTallerProg2.Vistas.Libros;
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
    public partial class LibrosInfo : Form
    {
        public LibrosInfo()
        {
            InitializeComponent();
        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            Libros.Libros ventanaLibro = new Libros.Libros();

            ventanaLibro.Visible = true;
        }
    }
}
