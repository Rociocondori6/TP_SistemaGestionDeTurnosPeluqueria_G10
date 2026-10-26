namespace PeluCli
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnClientes = new Button();
            btnTurnos = new Button();
            btnPromocion = new Button();
            btnReportes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 54);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión - Peluquería";
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(290, 112);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(228, 37);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Gestión de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTurnos.Location = new Point(290, 169);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(228, 37);
            btnTurnos.TabIndex = 2;
            btnTurnos.Text = "Gestión de Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnPromocion
            // 
            btnPromocion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromocion.Location = new Point(290, 227);
            btnPromocion.Name = "btnPromocion";
            btnPromocion.Size = new Size(228, 37);
            btnPromocion.TabIndex = 3;
            btnPromocion.Text = "Promociones y Fidelización";
            btnPromocion.UseVisualStyleBackColor = true;
            btnPromocion.Click += btnPromocion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(290, 285);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(228, 37);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes y Consultas";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnPromocion);
            Controls.Add(btnTurnos);
            Controls.Add(btnClientes);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClientes;
        private Button btnTurnos;
        private Button btnPromocion;
        private Button btnReportes;
    }
}