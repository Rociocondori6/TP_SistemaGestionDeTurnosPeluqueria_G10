namespace PeluCli
{
    partial class FormTurno
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
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            lblEstilista = new Label();
            cmbEstilista = new ComboBox();
            lblTurnoTitulo = new Label();
            lblServicio = new Label();
            cmbServicio = new ComboBox();
            lblFechaHora = new Label();
            dtpFechaHora = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            dgvTurnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(143, 89);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(143, 71);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblEstilista
            // 
            lblEstilista.AutoSize = true;
            lblEstilista.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstilista.Location = new Point(332, 71);
            lblEstilista.Name = "lblEstilista";
            lblEstilista.Size = new Size(46, 15);
            lblEstilista.TabIndex = 2;
            lblEstilista.Text = "Estilista";
            // 
            // cmbEstilista
            // 
            cmbEstilista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstilista.FormattingEnabled = true;
            cmbEstilista.Location = new Point(332, 89);
            cmbEstilista.Name = "cmbEstilista";
            cmbEstilista.Size = new Size(121, 23);
            cmbEstilista.TabIndex = 3;
            // 
            // lblTurnoTitulo
            // 
            lblTurnoTitulo.AutoSize = true;
            lblTurnoTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurnoTitulo.Location = new Point(141, 33);
            lblTurnoTitulo.Name = "lblTurnoTitulo";
            lblTurnoTitulo.Size = new Size(180, 25);
            lblTurnoTitulo.TabIndex = 4;
            lblTurnoTitulo.Text = "Resgistro de Turno";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServicio.Location = new Point(143, 124);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 5;
            lblServicio.Text = "Servicio";
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(143, 142);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(121, 23);
            cmbServicio.TabIndex = 6;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(332, 124);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(76, 15);
            lblFechaHora.TabIndex = 7;
            lblFechaHora.Text = "Fecha y Hora";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new Point(332, 142);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(200, 23);
            dtpFechaHora.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(141, 178);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(143, 196);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(141, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 39);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR TURNO";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDark;
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(332, 225);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 39);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(143, 270);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.Size = new Size(535, 168);
            dgvTurnos.TabIndex = 13;
            // 
            // FormTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTurnos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaHora);
            Controls.Add(lblFechaHora);
            Controls.Add(cmbServicio);
            Controls.Add(lblServicio);
            Controls.Add(lblTurnoTitulo);
            Controls.Add(cmbEstilista);
            Controls.Add(lblEstilista);
            Controls.Add(lblCliente);
            Controls.Add(cmbCliente);
            Name = "FormTurno";
            Text = "FormTurno";
            Load += FormTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private Label lblCliente;
        private Label lblEstilista;
        private ComboBox cmbEstilista;
        private Label lblTurnoTitulo;
        private Label lblServicio;
        private ComboBox cmbServicio;
        private Label lblFechaHora;
        private DateTimePicker dtpFechaHora;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView dgvTurnos;
    }
}