using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudianteInscripcionProyecto.UI.Registros;
using EstudianteInscripcionProyecto.UI.Consultas;

namespace EstudianteInscripcionProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteFormulario estudianteFormulario = new EstudianteFormulario();
            estudianteFormulario.StartPosition = FormStartPosition.CenterScreen;
            estudianteFormulario.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignaturasFormulario asignaturas = new AsignaturasFormulario();
            asignaturas.StartPosition = FormStartPosition.CenterScreen;
            asignaturas.Show();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionesFormulario inscripcionesFormulario = new InscripcionesFormulario();
            inscripcionesFormulario.StartPosition = FormStartPosition.CenterScreen;
            inscripcionesFormulario.Show();
        }

        private void EstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEstudianteRegistro consultaEstudianteRegistro = new ConsultaEstudianteRegistro();
            consultaEstudianteRegistro.StartPosition = FormStartPosition.CenterScreen;
            consultaEstudianteRegistro.Show();

        }
    }
}
