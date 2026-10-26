using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PeluCli
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            FormTurno formTurno = new FormTurno();
            formTurno.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            FormPromociones formPromocion = new FormPromociones();
            formPromocion.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();
            formReportes.Show();

        }
    }
}
