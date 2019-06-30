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
    public partial class InscripcionesFormulario : Form
    {
        public List<DetalleInscripciones> DetalleInscripciones;
        public InscripcionesFormulario()
        {
            this.DetalleInscripciones = new List<DetalleInscripciones>();
            InitializeComponent();
            LlenarComboBox();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DetalleIdnumericUpDown.Value = 0;
            MontonumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            this.DetalleInscripciones = new List<DetalleInscripciones>();
            CargarGrid();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Inscripciones LlenarClase()
        {
            Inscripciones inscripciones = new Inscripciones();
            inscripciones.InscripcionesId = (int)IdnumericUpDown.Value;
            inscripciones.FechaInscripcion = FechadateTimePicker.Value;
            inscripciones.EstudianteId =Convert.ToInt32(EstudiantecomboBox.SelectedValue);
            inscripciones.Monto = MontonumericUpDown.Value;
            inscripciones.DetalleInscripciones = this.DetalleInscripciones;
            return inscripciones;
        }

        private void LlenarCampo(Inscripciones inscripciones)
        {
            IdnumericUpDown.Value = inscripciones.InscripcionesId;
            FechadateTimePicker.Value = inscripciones.FechaInscripcion;
            MontonumericUpDown.Value = inscripciones.Monto;
            this.DetalleInscripciones = inscripciones.DetalleInscripciones;
            CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            if(MontonumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(MontonumericUpDown,"El monto no puede ser cero");
                MontonumericUpDown.Focus();
                paso = false;
            }
            if(this.DetalleInscripciones.Count == 0)
            {
                MyerrorProvider.SetError(DetalledataGridView,"El detalle no puede estar vacio");
                DetalledataGridView.Focus();
                paso = false;
            }
            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion;
            bool paso = false;

            if (!Validar())
                return;

            inscripcion = LlenarClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = InscripcionesBLL.Guardar(inscripcion);
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                inscripcion = InscripcionesBLL.Buscar(id);

                if (inscripcion != null)
                {
                    paso = InscripcionesBLL.Modificar(LlenarClase());
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdnumericUpDown.Value;
            Limpiar();
            try
            {
                if (InscripcionesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones inscripciones = new Inscripciones();
            int.TryParse(IdnumericUpDown.Text, out id);
            //id = (int)IDnumericUpDown.Value;
            Limpiar();
            try
            {
                inscripciones = InscripcionesBLL.Buscar(id);
                if (inscripciones != null)
                {
                    MessageBox.Show("Producto encontrado");
                    LlenarCampo(inscripciones);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe el producto");
            }
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.DetalleInscripciones;
        }

        private void AgregarAlGridbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            if (DetalledataGridView.DataSource != null)
                this.DetalleInscripciones = (List<DetalleInscripciones>) DetalledataGridView.DataSource;
            
            this.DetalleInscripciones.Add(
                new DetalleInscripciones(
                 DetalleInscripcionId:0,
                 EstudianteId: (int)EstudiantecomboBox.SelectedValue,
                 MontoDetalle: (int)MontonumericUpDown.Value,
                 Asignatura:1
                 )
               );
            CargarGrid();
            DetalledataGridView.Focus();
        }

        private void RemoverAlGrid_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                //remover la fila
                DetalleInscripciones.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void EstudianteButton_Click(object sender, EventArgs e)
        {
            EstudianteFormulario estudianteFormulario = new EstudianteFormulario();
            estudianteFormulario.StartPosition = FormStartPosition.CenterScreen;
            estudianteFormulario.ShowDialog();
        }

        private void LlenarComboBox()
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            var listado = new List<Estudiantes>();
            listado = repositorioBaseBLL.GetList(p => true);
            EstudiantecomboBox.DataSource = listado;
            EstudiantecomboBox.DisplayMember = "Nombres";
            EstudiantecomboBox.ValueMember = "EstudianteId";
        }
    }
}
