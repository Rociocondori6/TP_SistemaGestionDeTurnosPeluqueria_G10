namespace PeluCli
{
    partial class FormReportes
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
            cmbReportes = new ComboBox();
            btnGenerar = new Button();
            dataGridView1 = new DataGridView();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 36);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el reporte:";
            // 
            // cmbReportes
            // 
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(169, 70);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(209, 23);
            cmbReportes.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(421, 70);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(128, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "GENERAR REPORTE";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(517, 200);
            dataGridView1.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(169, 123);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(144, 23);
            dtpDesde.TabIndex = 5;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(337, 123);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(144, 23);
            dtpHasta.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesde.Location = new Point(169, 103);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(45, 15);
            lblDesde.TabIndex = 8;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHasta.Location = new Point(337, 103);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(41, 15);
            lblHasta.TabIndex = 9;
            lblHasta.Text = "Hasta:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenerar);
            Controls.Add(cmbReportes);
            Controls.Add(label1);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReportes;
        private Button btnGenerar;
        private DataGridView dataGridView1;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label lblDesde;
        private Label lblHasta;
    }
}