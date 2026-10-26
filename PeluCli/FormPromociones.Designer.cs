namespace PeluCli
{
    partial class FormPromociones
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
            lblPromocionesTitulo = new Label();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            lblCodigo = new Label();
            lblDescripcion = new Label();
            lblFechInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            nudDescuento = new NumericUpDown();
            lblDescuento = new Label();
            chkActiva = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dgvPromociones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            SuspendLayout();
            // 
            // lblPromocionesTitulo
            // 
            lblPromocionesTitulo.AutoSize = true;
            lblPromocionesTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromocionesTitulo.Location = new Point(162, 30);
            lblPromocionesTitulo.Name = "lblPromocionesTitulo";
            lblPromocionesTitulo.Size = new Size(229, 25);
            lblPromocionesTitulo.TabIndex = 0;
            lblPromocionesTitulo.Text = "Gestión de Promociones";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(162, 99);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(209, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(162, 152);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(209, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(162, 81);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(162, 134);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // lblFechInicio
            // 
            lblFechInicio.AutoSize = true;
            lblFechInicio.Location = new Point(399, 78);
            lblFechInicio.Name = "lblFechInicio";
            lblFechInicio.Size = new Size(86, 15);
            lblFechInicio.TabIndex = 5;
            lblFechInicio.Text = "Fecha de inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(399, 96);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(209, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(399, 134);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(71, 15);
            lblFechaFin.TabIndex = 7;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(399, 152);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(209, 23);
            dtpFechaFin.TabIndex = 8;
            // 
            // nudDescuento
            // 
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Location = new Point(162, 208);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(209, 23);
            nudDescuento.TabIndex = 9;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(162, 190);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento";
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(405, 212);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(121, 19);
            chkActiva.TabIndex = 11;
            chkActiva.Text = "Promoción Activa";
            chkActiva.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(163, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 33);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDark;
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(319, 245);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 33);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(475, 245);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 33);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvPromociones
            // 
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Location = new Point(162, 294);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.Size = new Size(549, 150);
            dgvPromociones.TabIndex = 15;
            // 
            // FormPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPromociones);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActiva);
            Controls.Add(lblDescuento);
            Controls.Add(nudDescuento);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechInicio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCodigo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(lblPromocionesTitulo);
            Name = "FormPromociones";
            Text = "FormPromociones";
            Load += FormPromociones_Load;
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPromocionesTitulo;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private Label lblCodigo;
        private Label lblDescripcion;
        private Label lblFechInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private NumericUpDown nudDescuento;
        private Label lblDescuento;
        private CheckBox chkActiva;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvPromociones;
    }
}