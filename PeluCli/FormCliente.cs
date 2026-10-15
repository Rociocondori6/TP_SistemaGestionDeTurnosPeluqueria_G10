using System;
using System.Windows.Forms;
using PeluCore.Models;
using PeluCore.Repositories;

namespace PeluCli
{
    public partial class FormCliente : Form
    {
        private int idSeleccionado = 0;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // Cargar los clientes existentes en el DataGridView
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                GenericRepository<Cliente> repo = new GenericRepository<Cliente>();
                dataGridView1.DataSource = repo.ObtenerTodos();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GenericRepository<Cliente> repo = new GenericRepository<Cliente>();
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };
                repo.Agregar(cliente);
                MessageBox.Show("!Cliente guardado correctamente!");
                CargarGrilla();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
                return;
            }
            try
            {
                GenericRepository<Cliente> repo = new GenericRepository<Cliente>();
                Cliente cliente = new Cliente()
                {
                    Id = idSeleccionado,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };
                repo.Modificar(cliente);
                MessageBox.Show("¡Cliente modificado correctamente!");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }
            try
            {
                GenericRepository<Cliente> repo = new GenericRepository<Cliente>();
                repo.Eliminar(idSeleccionado);
                MessageBox.Show("¡Cliente eliminado correctamente!");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString() ?? "";
                txtDNI.Text = fila.Cells["DNI"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                txtEmail.Text = fila.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            idSeleccionado = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío si no se necesita ninguna acción al hacer clic en la etiqueta.
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío si no se necesita ninguna acción al hacer clic en la etiqueta.
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío si no se necesita ninguna acción al cambiar el texto.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío si no se necesita ninguna acción al hacer clic en el botón.
        }
        private void label7_Click(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío si no se necesita ninguna acción al hacer clic en la etiqueta.
        }
    }
   
}
