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
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 68);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el reporte:";
            // 
            // cmbReportes
            // 
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(381, 70);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(155, 23);
            cmbReportes.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(558, 69);
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
            dataGridView1.Location = new Point(169, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(517, 200);
            dataGridView1.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(381, 107);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 4;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFecha);
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
        private DateTimePicker dtpFecha;
    }
}