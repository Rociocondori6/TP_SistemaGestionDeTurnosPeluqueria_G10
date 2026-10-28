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
            cmbReportes.Items.Add("Turnos Diarios (Agenda)");
            cmbReportes.Items.Add("Rendimiento por Estilista");
            cmbReportes.Items.Add("Servicios Más Solicitados");
            cmbReportes.Items.Add("Historial y Fidelización de Clientes");
            cmbReportes.Items.Add("Clientes Frecuentes (Beneficios)");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int seleccion = cmbReportes.SelectedIndex;

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;
            // Aquí puedes agregar la lógica para generar el reporte seleccionado
            switch (seleccion)
            {
                case 0:

                    dataGridView1.DataSource = new ReporteRepository().ObtenerTurnosPorFecha(fechaDesde, fechaHasta);
                    break;

                case 1:

                    dataGridView1.DataSource = new ReporteRepository().ObtenerRendimientoPorEstilista(fechaDesde, fechaHasta);
                    break;

                case 2:

                    dataGridView1.DataSource = new ReporteRepository().ObtenerServiciosMasDemandados(fechaDesde, fechaHasta);
                    break;

                case 3:
                    
                    dataGridView1.DataSource = new ReporteRepository().ObtenerHistorialClientes(fechaDesde, fechaHasta);
                    break;
                case 4:
                    
                    dataGridView1.DataSource = new ReporteRepository().ObtenerClientesFrecuentes(5);
                    var listaFrecuentes = new ReporteRepository().ObtenerClientesFrecuentes(5);
                    if (listaFrecuentes.Count == 0)
                    {
                        MessageBox.Show("Todavia no hay clientes que alcancen los 5 turnos registrados.", "Sin Resultados" +
                            "");
                    }
                    dataGridView1.DataSource = listaFrecuentes;
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione un reporte de la lista.");
                    break;
            }
        }
        
            
    }
}
