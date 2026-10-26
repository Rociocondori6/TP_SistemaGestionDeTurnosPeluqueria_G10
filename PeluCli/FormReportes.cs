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

                    DateTime desde0 = dtpDesde.Value.Date;
                    DateTime hasta0 = dtpHasta.Value.Date;


                    ReporteRepository reporteRepo = new ReporteRepository();
                    var listaTurnos = reporteRepo.ObtenerTurnosPorRangos(desde0, hasta0);

                    dataGridView1.DataSource = listaTurnos;
                    if (listaTurnos.Count == 0)
                    {
                        MessageBox.Show("No se encontraron turnos en el rango seleccionado.");
                    }
                    break;

                case 1:

                    DateTime desdeEstilista = dtpDesde.Value.Date;
                    DateTime hastaEstilista = dtpHasta.Value.Date;

                    ReporteRepository repoEstilista = new ReporteRepository();
                    var listaRendimiento = repoEstilista.ObtenerTurnosPorRangos(desdeEstilista, hastaEstilista);

                    dataGridView1.DataSource = listaRendimiento;
                    if (listaRendimiento.Count == 0)
                    {
                        MessageBox.Show("No se encontraron turnos en el rango seleccionado.");
                    }
                    break;

                case 2:

                    DateTime desdeServicio = dtpDesde.Value.Date;
                    DateTime hastaServicio  = dtpHasta.Value.Date;


                    ReporteRepository repoServicio = new ReporteRepository();
                    var servicios = repoServicio.ObtenerServiciosMasDemandados(desdeServicio, hastaServicio);
                    dataGridView1.DataSource = servicios;
                    if (servicios.Count == 0)
                    {
                        MessageBox.Show("No se encontraron servicios en el rango seleccionado.");
                    }
                    break;

                case 3:
                    
                    // logica
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
