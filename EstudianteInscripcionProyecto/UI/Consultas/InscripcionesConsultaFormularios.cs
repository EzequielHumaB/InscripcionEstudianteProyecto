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
    public partial class InscripcionesConsultaFormularios : Form
    {
        public InscripcionesConsultaFormularios()
        {
            InitializeComponent();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripciones = new Inscripciones();
            var listado = new List<Inscripciones>();
            if(FiltrarFechacheckBox.Checked == true)
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    try
                    {
                        switch (FiltrocomboBox.SelectedIndex)
                        {

                            case 0:
                                listado = InscripcionesBLL.GetList(p => true);
                                break;
                            case 1:
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = InscripcionesBLL.GetList(p => p.InscripcionesId == id);
                                break;
                            case 2:
                                listado = InscripcionesBLL.GetList(p => p.Monto.ToString() == CriteriotextBox.Text);
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                {
                    listado = InscripcionesBLL.GetList(p => true);
                }
                InscripcionesdataGridView.DataSource = null;
                InscripcionesdataGridView.DataSource = listado;
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
                                listado = InscripcionesBLL.GetList(p => true);
                                break;
                            case 1:
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = InscripcionesBLL.GetList(p => p.InscripcionesId == id);
                                break;
                            case 2:
                                listado = InscripcionesBLL.GetList(p => p.Monto.ToString() == CriteriotextBox.Text);
                                break;
                        }
                    }
                    catch (Exception)
                    {  }

                }
                else
                {
                    listado = InscripcionesBLL.GetList(p => true);
                }
                InscripcionesdataGridView.DataSource = null;
                InscripcionesdataGridView.DataSource = listado;
            }
        }

      }
           
    }
