using FinalTallerProg2.Logica;
using FinalTallerProg2.Logica.Autor;
using FinalTallerProg2.Logica.Estudiante;
using FinalTallerProg2.Logica.Libro;
using FinalTallerProg2.Vistas.Estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Vistas.Prestamos
{
    public partial class CrearPrestamo : Form
    {
        List<Estudiante> listaEst = new List<Estudiante>();
        List<Libro> listaLibros = new List<Libro>();

        BindingList<string> listNomEst = new BindingList<string>();
        BindingList<string> listNomLib = new BindingList<string>();

        Prestamo prestamo = new Prestamo();

        int indexEst = 0;
        int indexLib = 0;

        public CrearPrestamo()
        {
            InitializeComponent();
            cb_estudiante.DataSource = listNomEst;
            cb_libro.DataSource = listNomLib;
        }

        private void LimpiarCampos()
        {
            tb_nomEst.Text = "";
            tb_titLib.Text = "";
            mtxt_hasta.Text = "";
            ep_fechaHasta.SetError(mtxt_hasta, "La fecha de limite de prestamo es obligatoria");
        }

        private void CargarCbEstudiante(List<Estudiante> estudiantes) 
        {
            listNomEst.Clear();
            foreach (Estudiante est in estudiantes)
            {
                listNomEst.Add(est.Nombre);
            }

        }  

        private void CargarCbLibro(List<Libro> libros)
        {
            listNomLib.Clear();
            foreach(Libro libro in libros)
            {
                listNomLib.Add(libro.Titulo);
            }
        }

        public string darFormatoDate(string fecha)
        {
            string fechaFormateada = "";
            int j = 0;

            for(int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    fechaFormateada += "-";
                }
                else if(i == 5)
                {
                    fechaFormateada += "-";
                }
                else
                {
                    fechaFormateada += fecha[j];
                    j++;
                }
            }
            return fechaFormateada;

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            PrestamosV prestamos = new PrestamosV();
            prestamos.Visible = true;
            this.Close();
        }

        private void CrearPrestamo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerFechaAct();
            listaLibros.Clear();
            listaEst.Clear();
            listaLibros = Libro.ListarLibros();
            listaEst = Logica.Estudiante.Estudiante.ListarEstudiantes();
            CargarCbLibro(Libro.ListarLibros());
            CargarCbEstudiante(Logica.Estudiante.Estudiante.ListarEstudiantes());
        }

        public void EstablecerFechaAct()
        {
            DateTime fechaActual = new DateTime();
            
            fechaActual = cal_prestamo.TodayDate;

            mtxt_fechaActual.Text = ToFechaString(fechaActual);
        }

        public string ToFechaString(DateTime fecha)
        {
            string fechaString = "";

            if (fecha.Month < 10)
            {
                fechaString += "0" + fecha.Month;
            }
            else
            {
                fechaString += fecha.Month;
            }

            if (fecha.Day < 10)
            {
                fechaString += "0" + fecha.Day;
            }
            else
            {
                fechaString += fecha.Day;
            }

            fechaString += fecha.Year;

            return fechaString;
        }

        private void cal_prestamo_DateChanged(object sender, DateRangeEventArgs e)
        {
            prestamo.FechaPrestamo = cal_prestamo.TodayDate;
            prestamo.FechaDevolucion = cal_prestamo.SelectionEnd.Date;

            
            mtxt_fechaActual.Text = ToFechaString(prestamo.FechaPrestamo);
            mtxt_hasta.Text = ToFechaString(prestamo.FechaDevolucion);
        }

        private void cb_estudiante_Click(object sender, EventArgs e)
        {
            cb_estudiante.DroppedDown = true;
            
        }

        private void cb_estudiante_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_nomEst_TextChanged(object sender, EventArgs e)
        {
            if(tb_nomEst.Text != "")
            {
                string nomEst;
                nomEst = tb_nomEst.Text;
                listaEst.Clear();
                listaEst = Estudiante.Buscador(nomEst, "Nombre");
                CargarCbEstudiante(Estudiante.Buscador(nomEst, "Nombre"));
            }
            else if (tb_nomEst.Text == "")
            {
                CargarCbEstudiante(Logica.Estudiante.Estudiante.ListarEstudiantes());
            }
        }

        private void tb_titLib_TextChanged(object sender, EventArgs e)
        {
            if(tb_titLib.Text != "")
            {
                string titLib;
                titLib = tb_titLib.Text;
                listaLibros.Clear();
                listaLibros = Libro.Buscador(titLib, "Titulo");
                CargarCbLibro(Libro.Buscador(titLib, "Titulo"));
            } else if (tb_titLib.Text == "")
            {
                CargarCbLibro(Libro.ListarLibros());
            }
        }

        private void cb_estudiante_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
        private void cb_estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexEst = cb_estudiante.SelectedIndex;
        }

        private void cb_libro_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexLib = cb_libro.SelectedIndex;
        }

        private void mtxt_hasta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mtxt_hasta_TextChanged(object sender, EventArgs e)
        {
            if (mtxt_hasta.MaskCompleted)
            {
                ep_fechaHasta.SetError(mtxt_hasta, "");
            }
            else 
            {
                ep_fechaHasta.SetError(mtxt_hasta, "La fecha de limite de prestamo es obligatoria");
            }
        }

        private void btn_crear_prestamo_Click(object sender, EventArgs e)
        {
            bool estado = false;
            if (cb_estudiante.SelectedIndex < 0 ||
                cb_estudiante.SelectedIndex < 0 ||
                !mtxt_hasta.MaskCompleted ||
                !mtxt_fechaActual.MaskCompleted )
            {
                ep_crearPrestamo.SetError(btn_crear_prestamo, "por favor, llenar todos los campos!");
            }
            else if (cb_estudiante.SelectedIndex > -1 ||
                cb_estudiante.SelectedIndex > - 1 ||
                mtxt_hasta.MaskCompleted ||
                mtxt_fechaActual.MaskCompleted)
            {
                prestamo.CargaridEstidLib(listaEst[indexEst].IdEstudiante, listaLibros[indexLib].IdLibro);
                estado = Prestamo.CrearPrestamo(prestamo);
                //string cadena = prestamo.IdEstudiante().ToString()+"-"+prestamo.IdLibro().ToString()+"-"+ToFechaString(prestamo.FechaPrestamo)+ "-" + ToFechaString(prestamo.FechaDevolucion);
                //ep_crearPrestamo.SetError(btn_crear_prestamo,cadena);
                if (estado)
                {
                    MessageBox.Show("Se creo el prestamo exitosamente!", "Crear Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ah ocurrido un problema al crear el prestamo!", "Crear Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void mtxt_fechaActual_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxt_fechaActual.MaskCompleted)
            {
                ep_fechaInicial.SetError(mtxt_fechaActual, "");
            }
            else
            {
                ep_fechaInicial.SetError(mtxt_fechaActual, "La fecha de limite de prestamo es obligatoria");
            }
        }

        private void btn_nuevoEstudiante_Click(object sender, EventArgs e)
        {
            CrearEstudiante crearEstudiante = new CrearEstudiante();
            crearEstudiante.Visible = true;

            //listaEst = Estudiante.ListarEstudiantes();
            CargarCbEstudiante(Estudiante.ListarEstudiantes());
        }

        private void btn_nuevoLibro_Click(object sender, EventArgs e)
        {

        }
    }
}
