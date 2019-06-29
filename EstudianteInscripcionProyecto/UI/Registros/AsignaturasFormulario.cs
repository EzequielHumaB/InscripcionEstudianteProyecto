using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudianteInscripcionProyecto.Entidades;
using EstudianteInscripcionProyecto.BLL;

namespace EstudianteInscripcionProyecto.UI.Registros
{
    public partial class AsignaturasFormulario : Form
    {
        public AsignaturasFormulario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CreditosnumericUpDown.Value = 0;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarCampo(Asignaturas asignaturas)
        {
           
            IdnumericUpDown.Value = asignaturas.AsignaturaId;
            DescripciontextBox.Text = asignaturas.Descripcion;
            CreditosnumericUpDown.Value = asignaturas.Creditos;
        }

        private Asignaturas LlenarClase()
        {
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = (int)IdnumericUpDown.Value;
            asignaturas.Descripcion = DescripciontextBox.Text;
            asignaturas.Creditos = (short)CreditosnumericUpDown.Value;
            return asignaturas;
        }

        private bool Validar()
        {
            bool paso = true;
            if(string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "Tienes que llenar el nombre");
                DescripciontextBox.Focus();
                paso = false;
            }

            if(CreditosnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CreditosnumericUpDown,"Una materia no puede tener cero creditos");
                CreditosnumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
            return repositorioBaseBLL.Buscar((int)IdnumericUpDown.Value) != null;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Asignaturas asignaturas = new Asignaturas();
            if (!Validar())
            {
                return;
            }

            asignaturas = LlenarClase();
            if (IdnumericUpDown.Value == 0)
            {
                RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
                paso = repositorioBaseBLL.Guardar(asignaturas);
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
                asignaturas = repositorioBaseBLL.Buscar(id);
                if (asignaturas != null)
                {
                    paso = repositorioBaseBLL.Modificar(LlenarClase());
                    MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id no existe", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (paso)
            {
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdnumericUpDown.Value;
            try
            {
                RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
                if(repositorioBaseBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado con existo");
                    Limpiar();
                }

            }catch
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdnumericUpDown.Value;
            Asignaturas asignaturas = new Asignaturas();
            try
            {
                RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();
                asignaturas = repositorioBaseBLL.Buscar(id);
                if(asignaturas!=null)
                {
                    MessageBox.Show("Asignatura encontrada");
                    LlenarCampo(asignaturas);
                }
            }catch
            {
                MessageBox.Show("La asignatura no existe");
            }
        }
    }
}
    