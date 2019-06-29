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
            bool paso = false;
            Estudiantes estudiantes = new Estudiantes();
            if(!Validar())
            {
                return;
            }

            estudiantes = LlenarClase();
            if(IdEstudiantenumericUpDown.Value == 0)
            {
                // RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
                //  paso = repositorioBaseBLL.Guardar(estudiantes);
                paso = EstudiantesBLL.Guardar(estudiantes);
                MessageBox.Show("Guardado","Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                int id = Convert.ToInt32(IdEstudiantenumericUpDown.Value);
                //   RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
                //  estudiantes = repositorioBaseBLL.Buscar(id);
                estudiantes = EstudiantesBLL.Buscar(id);
                if(estudiantes!=null)
                {
                    // paso = repositorioBaseBLL.Modificar(LlenarClase());
                    paso = EstudiantesBLL.Modificar(LlenarClase());
                    MessageBox.Show("Modificado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id no existe", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if(paso)
            {
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar","Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdEstudiantenumericUpDown.Value;
            Limpiar();
            try
            {
                //    RepositorioBaseBLL<Estudiantes> repositorio = new RepositorioBaseBLL<Estudiantes>();

                Estudiantes estudiantes = new Estudiantes();
                 
                if(EstudiantesBLL.Eliminar(id))
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
                estudiantes = EstudiantesBLL.Buscar(id);
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
