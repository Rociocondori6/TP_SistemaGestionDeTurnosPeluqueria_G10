using PeluCore.Models;
using PeluCore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PeluCore.Data;

namespace PeluCli
{
    public partial class FormTurno : Form
    {
        public FormTurno()
        {
            InitializeComponent();
        }

        private void FormTurno_Load(object sender, EventArgs e)
        {
            // inserta datos automaticamente en los combos al cargar el formulario
            VerificarYCrearDatosDePrueba();

            CargarCombos();
            CargarGrillaTurnos();

        }

        private void VerificarYCrearDatosDePrueba()
        {
            using (var context = new AplicationDbContext())
            {
                if (!context.Clientes.Any())
                {
                    context.Clientes.Add(new Cliente { Nombre = "Maria", Apellido = "Perez", DNI = "12345678", Telefono = "3492339988", Email = "maria@example.com" });
                    context.Clientes.Add(new Cliente { Nombre = "Luz", Apellido = "Alvarez", DNI = "12345678", Telefono = "3493339988", Email = "luz@example.com" });
                }

                if (!context.Estilistas.Any())
                {
                    context.Estilistas.Add(new Estilista { Nombre = "Martin", Apellido = "Gomez", Especialidad = "Colorista" });
                    context.Estilistas.Add(new Estilista { Nombre = "Luis", Apellido = "Martinez", Especialidad = "Barbero" });
                }

                if (!context.Servicios.Any())
                {
                    context.Servicios.Add(new Servicio { Nombre = "Corte de Cabello", DuracionMinima = 30, Precio = 500 });
                    context.Servicios.Add(new Servicio { Nombre = "Coloración", DuracionMinima = 60, Precio = 1500 });
                }

                context.SaveChanges();
            }
        }
        private void CargarCombos()
        {
            // cargar clientes 
            GenericRepository<Cliente> clienteRepo = new GenericRepository<Cliente>();
            cmbCliente.DataSource = clienteRepo.ObtenerTodos()
                .Select(c => new { c.Id, Nombre = c.Nombre + " " + c.Apellido }).ToList();
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "Id";

            // cargar estilistas
            GenericRepository<Estilista> estilistaRepo = new GenericRepository<Estilista>();
            cmbEstilista.DataSource = estilistaRepo.ObtenerTodos()
                .Select(e => new { e.Id, Nombre = e.Nombre + " " + e.Apellido }).ToList();
            cmbEstilista.DisplayMember = "NombreCompleto";
            cmbEstilista.ValueMember = "Id";

            // cargar servicios
            GenericRepository<Servicio> servicioRepo = new GenericRepository<Servicio>();
            cmbServicio.DataSource = servicioRepo.ObtenerTodos();
            cmbServicio.DisplayMember = "Nombre";
            cmbServicio.ValueMember = "Id";

            // estados
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Confirmado");
            cmbEstado.Items.Add("Cancelado");
            cmbEstado.SelectedIndex = 0; // Selecciona el primer estado por defecto
        }

        private void CargarGrillaTurnos()
        {
            TurnoRepository turnoRepo = new TurnoRepository();
            dgvTurnos.DataSource = turnoRepo.ObtenerTurnosParaGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue == null || cmbEstilista.SelectedValue == null || cmbServicio.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un cliente, un estilista y un servicio.");
                    return;
                }
                TurnoRepository turnoRepo = new TurnoRepository();
                Turno turno = new Turno
                {
                    FechaHora = dtpFechaHora.Value,
                    ClienteId = (int)cmbCliente.SelectedValue,
                    EstilistaId = (int)cmbEstilista.SelectedValue,
                    ServicioId = (int)cmbServicio.SelectedValue,
                    Estado = cmbEstado.SelectedItem.ToString()
                };

                GenericRepository<Turno> turnoRepoGeneric = new GenericRepository<Turno>();
                turnoRepoGeneric.Agregar(turno);
                MessageBox.Show("¡Turno guardado correctamente!");
                CargarGrillaTurnos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el turno: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            dtpFechaHora.Value = DateTime.Now;
            cmbCliente.SelectedIndex = -1;
            cmbEstilista.SelectedIndex = -1;
            cmbServicio.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0; // Selecciona el primer estado por defecto
        }
    }
}
