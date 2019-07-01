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
    public partial class ConsultaEstudianteRegistro : Form
    {
        public ConsultaEstudianteRegistro()
        {
            InitializeComponent();
        }

        private void BucarButton_Click(object sender, EventArgs e)
        {
            RepositorioBaseBLL<Estudiantes> repositorioBaseBLL = new RepositorioBaseBLL<Estudiantes>();
            var listado = new List<Estudiantes>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    //Todo
                    case 0:
                        listado = repositorioBaseBLL.GetList(p => true);
                        break;
                    case 1: //Seleccionar ID
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorioBaseBLL.GetList(p => p.EstudianteId == id);
                        break;
                    case 2:
                        listado = repositorioBaseBLL.GetList(p => p.Nombres==CriteriotextBox.Text);
                        break;
                    case 3:
                       
                        listado = repositorioBaseBLL.GetList(p => p.Balance == CriteriotextBox.Text);
                        break;                    
                         
                }

            }
            else
            {
                listado = repositorioBaseBLL.GetList(p => true);
            }
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = listado;
        }
    }
    }
}
