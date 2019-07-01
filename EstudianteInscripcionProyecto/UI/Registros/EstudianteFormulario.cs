using EstudianteInscripcionProyecto.Entidades;
using System;
using System.Windows.Forms;
using EstudianteInscripcionProyecto.BLL;

namespace EstudianteInscripcionProyecto.UI.Registros
{
    public partial class EstudianteFormulario : Form
    {
        public EstudianteFormulario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdEstudiantenumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            BalancenumericUpDown.Value = 0;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Estudiantes LlenarClase()
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = (int)IdEstudiantenumericUpDown.Value;
            estudiantes.Nombres = NombretextBox.Text;
            estudiantes.FechaIngreso = FechadateTimePicker.Value;
            estudiantes.Balance = BalancenumericUpDown.Value;
            return estudiantes;
        }

        private void LlenarCampo(Estudiantes estudiantes)
        {
            IdEstudiantenumericUpDown.Value = estudiantes.EstudianteId;
            NombretextBox.Text = estudiantes.Nombres;
            FechadateTimePicker.Value = estudiantes.FechaIngreso;
            BalancenumericUpDown.Value = estudiantes.Balance;
        }

        private bool ExistenEnLaBaseDeDatos()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            return repositorioBaseBLL.Buscar((int)IdEstudiantenumericUpDown.Value) != null;
        }

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "Tienes que ingresar el nombre");
                NombretextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBaseBLL<Estudiantes> repositorio = new RepositorioBaseBLL<Estudiantes>();
            bool paso = false;

            if (!Validar())
                return;

            Estudiantes estudiante = LlenarClase();

            if (IdEstudiantenumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(estudiante);
            }
            else
            {
                if (!ExistenEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe");
                }
                else
                {
                    paso = repositorio.Modificar(estudiante);
                }
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdEstudiantenumericUpDown.Value;
            Limpiar();
            try
            {
                RepositorioBaseBLL<Estudiantes> repositorio = new RepositorioBaseBLL<Estudiantes>();

                Estudiantes estudiantes = new Estudiantes();
                 
                if(repositorio.Eliminar(1))
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }catch
            {
                MessageBox.Show("El estudiante no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiantes = new Estudiantes();
            id = (int)IdEstudiantenumericUpDown.Value;
            // int.TryParse(IdEstudiantenumericUpDown.Text, out id);

            RepositorioBaseBLL<Estudiantes> repositorio = new RepositorioBaseBLL<Estudiantes>();
           
            Limpiar();
            try
            {
               estudiantes = repositorio.Buscar(id);
                if (estudiantes != null)
                {
                    MessageBox.Show("Estudiante encontrado");
                    LlenarCampo(estudiantes);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe el estudiante");
            }
        }
    }
}
