using FinalTallerProg2.Vistas.Autores;
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
    public partial class AutoresInfo : Form
    {
        public AutoresInfo()
        {
            InitializeComponent();
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            Autores.Autores autores = new Autores.Autores();

            autores.Visible = true;
        }
    }
}
