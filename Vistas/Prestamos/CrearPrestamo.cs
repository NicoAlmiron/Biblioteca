using Entidades;
using Negocio;
using FinalTallerProg2.Vistas.Estudiantes;
using FinalTallerProg2.Vistas.Inicio;
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
            // solo cierro, la pantalla que me abrio se vuelve a mostrar sola
            this.Close();

        }

        private void CrearPrestamo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerFechaAct();
            listaLibros = LibroNegocio.ListarLibros();
            listaEst = EstudianteNegocio.ListarEstudiantes();
            CargarCbLibro(listaLibros);
            CargarCbEstudiante(listaEst);
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
            mtxt_hasta.Text = ToFechaString(prestamo.FechaDevolucion.Value);
        }

        // lee una fecha escrita en el MaskedTextBox (formato mes/dia/año, igual que ToFechaString)
        private DateTime? LeerFecha(MaskedTextBox mtxt)
        {
            string soloNumeros = new string(mtxt.Text.Where(char.IsDigit).ToArray());
            DateTime fecha;

            if (DateTime.TryParseExact(soloNumeros, "MMddyyyy", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out fecha))
            {
                return fecha;
            }
            return null;
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
            // listaEst y el combo tienen que tener SIEMPRE los mismos elementos en el mismo orden,
            // porque el indice del combo se usa para sacar el id de listaEst
            if(tb_nomEst.Text != "")
            {
                listaEst = EstudianteNegocio.Buscador(tb_nomEst.Text, "Nombre");
            }
            else
            {
                listaEst = EstudianteNegocio.ListarEstudiantes();
            }
            CargarCbEstudiante(listaEst);
        }

        private void tb_titLib_TextChanged(object sender, EventArgs e)
        {
            // igual que con estudiantes: la lista y el combo tienen que coincidir
            if(tb_titLib.Text != "")
            {
                listaLibros = LibroNegocio.Buscador(tb_titLib.Text, "Titulo");
            }
            else
            {
                listaLibros = LibroNegocio.ListarLibros();
            }
            CargarCbLibro(listaLibros);
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
            // las fechas las leo de los campos de texto, asi funciona aunque no se haya tocado el calendario
            DateTime? fechaPrestamo = LeerFecha(mtxt_fechaActual);
            DateTime? fechaHasta = LeerFecha(mtxt_hasta);

            if (cb_estudiante.SelectedIndex < 0 ||
                cb_libro.SelectedIndex < 0 ||
                fechaPrestamo == null ||
                fechaHasta == null)
            {
                ep_crearPrestamo.SetError(btn_crear_prestamo, "por favor, llenar todos los campos con fechas validas!");
            }
            else if (fechaHasta.Value < fechaPrestamo.Value)
            {
                ep_crearPrestamo.SetError(btn_crear_prestamo, "la fecha limite no puede ser anterior a la del prestamo!");
            }
            else
            {
                ep_crearPrestamo.SetError(btn_crear_prestamo, "");
                prestamo.FechaPrestamo = fechaPrestamo.Value;
                prestamo.FechaDevolucion = fechaHasta.Value;
                prestamo.CargaridEstidLib(listaEst[indexEst].IdEstudiante, listaLibros[indexLib].IdLibro);
                estado = PrestamoNegocio.CrearPrestamo(prestamo);
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
            // escondo esta pantalla mientras se crea el estudiante
            this.Hide();
            crearEstudiante.ShowDialog();
            this.Show();

            listaEst.Clear();
            listaEst = EstudianteNegocio.ListarEstudiantes();
            CargarCbEstudiante(listaEst);
        }

        private void btn_nuevoLibro_Click(object sender, EventArgs e)
        {
            CrearLibro crearLibro = new CrearLibro();
            // escondo esta pantalla mientras se crea el libro
            this.Hide();
            crearLibro.ShowDialog();
            this.Show();

            listaLibros.Clear();
            listaLibros = LibroNegocio.ListarLibros();
            CargarCbLibro(listaLibros);
        }
    }
}
