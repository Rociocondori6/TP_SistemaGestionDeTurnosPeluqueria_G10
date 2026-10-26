using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PeluCore.Models;
using PeluCore.Repositories;

namespace PeluCli
{
    public partial class FormPromociones : Form
    {
        // guardamos el id si el usuario selecciona un fila para editar o eliminar
        private int? _promocionIdSeleccionada = null;
        public FormPromociones()
        {
            InitializeComponent();
        }

        private void FormPromociones_Load(object sender, EventArgs e)
        {
            CargarGrillaPromociones();
            LimpiarCampos();
        }

        private void CargarGrillaPromociones()
        {
            GenericRepository<Promocion> repo = new GenericRepository<Promocion>();
            dgvPromociones.DataSource = repo.ObtenerTodos()
                .Select(p => new
                {
                    p.Id,
                    p.Codigo,
                    p.Descripcion,
                    Descuento = p.Descuento.ToString("N2") + "%",
                    FechaInicio = p.FechaInicio.ToString("dd/MM/yyyy"),
                    FechaFin = p.FechaFin.ToString("dd/MM/yyyy"),
                    Estado = p.Activa ? "Activa" : "Inactiva"
                }).ToList();


        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            nudDescuento.Value = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddDays(7);
            chkActiva.Checked = true;
            _promocionIdSeleccionada = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número válido.");
                    return;
                }

                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                    return;
                }

                GenericRepository<Promocion> repo = new GenericRepository<Promocion>();
                if (_promocionIdSeleccionada.HasValue)
                {
                    // Modificar promoción existente
                    Promocion promocion = repo.ObtenerPorId(_promocionIdSeleccionada.Value);
                    if (promocion != null)
                    {
                        promocion.Codigo = codigo;
                        promocion.Descripcion = txtDescripcion.Text;
                        promocion.Descuento = nudDescuento.Value;
                        promocion.FechaInicio = dtpFechaInicio.Value;
                        promocion.FechaFin = dtpFechaFin.Value;
                        promocion.Activa = chkActiva.Checked;
                        repo.Modificar(promocion);
                        MessageBox.Show("¡Promoción modificada correctamente!");
                    }
                }
                else
                {
                    // Crear nueva promoción
                    Promocion nuevaPromocion = new Promocion
                    {
                        Codigo = codigo,
                        Descripcion = txtDescripcion.Text,
                        Descuento = nudDescuento.Value,
                        FechaInicio = dtpFechaInicio.Value,
                        FechaFin = dtpFechaFin.Value,
                        Activa = chkActiva.Checked
                    };
                    repo.Agregar(nuevaPromocion);
                    MessageBox.Show("¡Promoción guardada correctamente!");
                }
                CargarGrillaPromociones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la promoción: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCodigo.Text) || !int.TryParse(txtCodigo.Text, out int codigoBuscado))
            {
                MessageBox.Show("Seleccione una promoción para eliminar.");
                return;
            }

            GenericRepository<Promocion> repo = new GenericRepository<Promocion>();
            var promocionEncontrada = repo.ObtenerTodos().FirstOrDefault(p => p.Codigo == codigoBuscado);
            if (promocionEncontrada == null)
            {
                MessageBox.Show("No se encontró la promoción seleccionada.");
            }
            var respuesta = MessageBox.Show("¿Está seguro de que desea eliminar la promoción seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (respuesta == DialogResult.Yes)
            {
                repo.Eliminar(promocionEncontrada.Id);
                MessageBox.Show("¡Promoción eliminada correctamente!");
                CargarGrillaPromociones();
                LimpiarCampos();
            }
            
        }
    }
}
