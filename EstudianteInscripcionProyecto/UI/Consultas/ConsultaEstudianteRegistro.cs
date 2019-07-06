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
            if(FiltrarFechacheckBox.Checked == true)
            {
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
                                listado = repositorioBaseBLL.GetList(p => p.EstudianteId == id);
                                break;
                            case 2:
                                listado = repositorioBaseBLL.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;
                            case 3:
                                listado = repositorioBaseBLL.GetList(p => p.Balance.ToString() == CriteriotextBox.Text);
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                    listado = repositorioBaseBLL.GetList(p => true);


                EstudiantedataGridView.DataSource = null;
                EstudiantedataGridView.DataSource = listado;
            }

            else
            {
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
                                listado = repositorioBaseBLL.GetList(p => p.EstudianteId == id);
                                break;
                            case 2:
                                listado = repositorioBaseBLL.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;
                            case 3:
                                listado = repositorioBaseBLL.GetList(p => p.Balance.ToString() == CriteriotextBox.Text);
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                    listado = repositorioBaseBLL.GetList(p => true);


                EstudiantedataGridView.DataSource = null;
                EstudiantedataGridView.DataSource = listado;
            }
        }

    }

    }
   

