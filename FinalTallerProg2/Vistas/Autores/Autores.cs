using FinalTallerProg2.Logica.Autor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Vistas.Autores
{
    public partial class Autores : Form
    {
        int idAutSelec = 0;
        BindingList<Autor> listaAutores = new BindingList<Autor>();

        public Autores()
        {
            InitializeComponent();
            LimpiarCampos();
            dgv_autores.DataSource = listaAutores;
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            CargarDatos(Autor.ListarAutores());
        }

        private void CargarDatos(List<Autor> ListaRespuesta)
        {
            listaAutores.Clear();
            foreach (Autor autor in ListaRespuesta)
            {
                listaAutores.Add(autor);
            }

        }

        public void LimpiarCampos()
        {
            tb_nombre_autor.Text = "";
            ep_nomAut.SetError(tb_nombre_autor, "Este campo es obligatorio!");
            btn_crear_autor.Enabled = false;
            tb_nacionalidad_autor.Text = "";
        }

        private void btn_crear_autor_Click(object sender, EventArgs e)
        {

            bool resultado = false;

            Autor nuevoAutor = new Autor();
            nuevoAutor.Nombre = tb_nombre_autor.Text;
            nuevoAutor.Nacionalidad = tb_nacionalidad_autor.Text;

            resultado = Autor.CrearAutor(nuevoAutor);

            if (resultado)
            {
                MessageBox.Show("Se Agrego el autor correctamente!","Crear Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(Autor.ListarAutores());
                LimpiarCampos();
            } else
            {
                MessageBox.Show("Ah ocurrido un error al crear el autor!", "Crear Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tb_nombre_autor_TextChanged(object sender, EventArgs e)
        {
            if(tb_nombre_autor.Text == "" && string.IsNullOrEmpty(tb_nombre_autor.Text))
            {
                ep_nomAut.SetError(tb_nombre_autor,"Este campo es obligatorio!");
                btn_crear_autor.Enabled = false;
            }
            else
            {
                if(idAutSelec == 0)
                {
                    btn_crear_autor.Enabled = true;
                }
                ep_nomAut.SetError(tb_nombre_autor, "");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_autores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAutSelec = Convert.ToInt32(dgv_autores.Rows[e.RowIndex].Cells[0].Value);

            Autor autorEditar = new Autor();

            autorEditar = Autor.BuscarAutorXId(idAutSelec);

            tb_nombre_autor.Text = autorEditar.Nombre;
            tb_nacionalidad_autor.Text = autorEditar.Nacionalidad;

            btn_editar_autor.Enabled = true;
            btn_crear_autor.Enabled=false;

        }

        private void btn_editar_autor_Click(object sender, EventArgs e)
        {
            if(idAutSelec > 0)
            {
                Autor autorEditado = new Autor();

                autorEditado.Nombre = tb_nombre_autor.Text;
                autorEditado.Nacionalidad = tb_nacionalidad_autor.Text;
                autorEditado.IdAutor = idAutSelec;

                if (Autor.EditarAutor(autorEditado))
                {
                    MessageBox.Show("Se editaron los datos Correctamente!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos(Autor.ListarAutores());
                }
                else
                {
                    MessageBox.Show("Ah ocurrido un error al intentar editar los datos!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se a seleccionado ningun autor!", "Editar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_autor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = new DialogResult();

            if(idAutSelec > 0)
            {
                confirmacion = MessageBox.Show("Esta seguro que deseas eliminar este autor?", "Eliminar Autor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(confirmacion == DialogResult.Yes)
                {
                    bool respuesta = false;

                    respuesta = Autor.EliminarAutor(idAutSelec);
                    if(respuesta)
                    {
                        MessageBox.Show("Se a Eliminado el autor Exitosamente!", "Eliminar Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos(Autor.ListarAutores());
                    }
                    else
                    {
                        MessageBox.Show("Ah ocurrido un error al intentar eliminar el autor!", "Eliminar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No se a seleccionado ningun autor!", "Eliminar Autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_bucador_autor_TextChanged(object sender, EventArgs e)
        {
            if(cb_categoria.Text != "")
            {
                string txt, categoria;
                categoria = cb_categoria.Text;
                txt = tb_bucador_autor.Text;

                CargarDatos(Autor.Buscador(txt,categoria));

                ep_categoria.SetError(cb_categoria, "");
            }
            else 
            {
                ep_categoria.SetError(cb_categoria, "Seleccione una categoria");
            }
        }
    }
}
