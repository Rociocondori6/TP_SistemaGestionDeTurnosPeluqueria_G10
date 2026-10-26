using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PeluCore.Repositories;

namespace PeluCli
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            cmbReportes.Items.Add("1. Turnos Diarios (Agenda)");
            cmbReportes.Items.Add("2. Rendiemiento por Estilista");
            cmbReportes.Items.Add("3. Servicios Más Solicitados");
            cmbReportes.Items.Add("4. Historial y Fidelización de Clientes");
            cmbReportes.Items.Add("5. Clientes Frecuentes (Benificios)");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int seleccion = cmbReportes.SelectedIndex;
           
            // Aquí puedes agregar la lógica para generar el reporte seleccionado
            switch (seleccion)
            {
                case 0:
                    DateTime fechaSeleccionada = dtpFecha.Value;
                    ReporteRepository reporteRepo = new ReporteRepository();
                    var listaTurnos = reporteRepo.ObtenerTurnosDiarios(fechaSeleccionada);

                    dataGridView1.DataSource = listaTurnos;
                    if (listaTurnos.Count == 0)
                    {
                        MessageBox.Show("No hay turnos para la fecha seleccionada.");
                    }
                    break;
                case 1:
                    MessageBox.Show("2. Cargando Rendiemiento por Estilista...");   
                    // Lógica para generar el reporte de rendimiento por estilista
                    break;
                case 2:
                    MessageBox.Show("3. Cargando Servicios Más Solicitados...");
                    // Lógica para generar el reporte de servicios más solicitados
                    break;
                case 3:
                    MessageBox.Show("4. Cargando Historial y Fidelización de Clientes...");
                    // Lógica para generar el reporte de historial y fidelización de clientes
                    break;
                case 4:
                    MessageBox.Show("5. Cargando Clientes Frecuentes...");
                    // Lógica para generar el reporte de clientes frecuentes
                    break;
                default:
                    MessageBox.Show("Reporte no reconocido.");
                    break;
            }
        }
        
            
    }
}
