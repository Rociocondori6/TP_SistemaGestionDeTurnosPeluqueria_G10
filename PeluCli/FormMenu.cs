using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;



namespace PeluCli
{
    public partial class FormMenu : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FormMenu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            var formTurno = _serviceProvider.GetRequiredService<FormTurno>();
            formTurno.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var formCliente = _serviceProvider.GetRequiredService<FormCliente>();
            formCliente.ShowDialog();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            var formPromocion = _serviceProvider.GetRequiredService<FormPromociones>();
            formPromocion.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var formReportes = _serviceProvider.GetRequiredService<FormReportes>();
            formReportes.ShowDialog();

        }
    }
}
