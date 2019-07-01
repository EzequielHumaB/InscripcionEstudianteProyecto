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

namespace EstudianteInscripcionProyecto.UI.Consultas
{
    public partial class ConsultaAsignaturasFormulario : Form
    {
        public ConsultaAsignaturasFormulario()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            RepositorioBaseBLL<Asignaturas> repositorioBaseBLL = new RepositorioBaseBLL<Asignaturas>();

            var listado = new List<Asignaturas>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                try
                {
                    switch (FiltrocomboBox.SelectedIndex)
                    {

                        case 0:
                            listado = repositorioBaseBLL.GetList(p => true);
                            break;
                        case 1:
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repositorioBaseBLL.GetList(p => p.AsignaturaId == id);
                            break;
                        case 2:
                            listado = repositorioBaseBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                            break;
                        case 3:
                            listado = repositorioBaseBLL.GetList(p => p.Creditos.ToString() == CriteriotextBox.Text);
                            break;
                    }
                }
                catch (Exception)
                {

                }
                
            }
            else
            {
                listado = repositorioBaseBLL.GetList(p => true);
            }
            AsignautasdataGridView.DataSource = null;
            AsignautasdataGridView.DataSource = listado;
        }

       
    }
}
