using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Vistas.Consultas
{
    // pantalla de consultas: se elige una en el ListBox
    // y el resultado se muestra en el DataGridView
    // (los titulos de las consultas estan cargados en los Items del ListBox desde el diseñador)
    public partial class ConsultasV : Form
    {
        public ConsultasV()
        {
            InitializeComponent();
        }

        private void ConsultasV_Load(object sender, EventArgs e)
        {
        }

        private void lst_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_consultas.SelectedIndex < 0)
            {
                return;
            }

            // el primer item del ListBox es el 0, pero las consultas van del 1 al 15
            int numero = lst_consultas.SelectedIndex + 1;

            // muestro el SQL que se ejecuta, asi se ve que consulta resuelve cada punto
            txt_sql.Text = ConsultasNegocio.ObtenerConsulta(numero);

            DataTable resultado = ConsultasNegocio.Ejecutar(numero);
            dgv_resultado.DataSource = resultado;

            lbl_resultado.Text = "Resultado: " + resultado.Rows.Count + " fila(s)";
        }
    }
}
