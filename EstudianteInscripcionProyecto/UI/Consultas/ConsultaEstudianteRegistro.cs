﻿using System;
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
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date &&
                c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorioBaseBLL.GetList(p => true);
            }
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = listado;
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EstudiantedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

