namespace Payroll_1.Formularios
{
    partial class generarNomina
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
            dgvEmpleados = new DataGridView();
            dgvDeducciones = new DataGridView();
            cbxDeducciones = new ComboBox();
            btnAsignar = new Button();
            btnRegresar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            txtSueldoBase = new Label();
            txtSalarioNeto = new Label();
            txtTotalDeducciones = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(70, 56);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(633, 150);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            dgvEmpleados.MouseClick += dgvEmpleados_MouseClick;
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(70, 295);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(408, 150);
            dgvDeducciones.TabIndex = 1;
            // 
            // cbxDeducciones
            // 
            cbxDeducciones.FormattingEnabled = true;
            cbxDeducciones.Location = new Point(582, 295);
            cbxDeducciones.Name = "cbxDeducciones";
            cbxDeducciones.Size = new Size(121, 23);
            cbxDeducciones.TabIndex = 2;
            cbxDeducciones.SelectedValueChanged += cbxDeducciones_SelectedValueChanged;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(582, 334);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(121, 23);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(458, 241);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(89, 26);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 277);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Deducciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 465);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Complementos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 483);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(408, 150);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(70, 679);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(408, 150);
            dataGridView2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 661);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 10;
            label4.Text = "Percepciones";
            label4.Click += label4_Click;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.AutoSize = true;
            txtSueldoBase.Location = new Point(595, 219);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(73, 15);
            txtSueldoBase.TabIndex = 12;
            txtSueldoBase.Tag = "";
            txtSueldoBase.Text = "Sueldo Base:";
            // 
            // txtSalarioNeto
            // 
            txtSalarioNeto.AutoSize = true;
            txtSalarioNeto.Location = new Point(582, 430);
            txtSalarioNeto.Name = "txtSalarioNeto";
            txtSalarioNeto.Size = new Size(74, 15);
            txtSalarioNeto.TabIndex = 13;
            txtSalarioNeto.Text = "Salario Neto:";
            // 
            // txtTotalDeducciones
            // 
            txtTotalDeducciones.AutoSize = true;
            txtTotalDeducciones.Location = new Point(404, 448);
            txtTotalDeducciones.Name = "txtTotalDeducciones";
            txtTotalDeducciones.Size = new Size(35, 15);
            txtTotalDeducciones.TabIndex = 14;
            txtTotalDeducciones.Text = "Total:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // generarNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 814);
            Controls.Add(pictureBox1);
            Controls.Add(txtTotalDeducciones);
            Controls.Add(txtSalarioNeto);
            Controls.Add(txtSueldoBase);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(btnAsignar);
            Controls.Add(cbxDeducciones);
            Controls.Add(dgvDeducciones);
            Controls.Add(dgvEmpleados);
            Name = "generarNomina";
            Text = "generarNomina";
            Load += asignarDeduccionesEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DataGridView dgvDeducciones;
        private ComboBox cbxDeducciones;
        private Button btnAsignar;
        private Button btnRegresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label txtSueldoBase;
        private Label txtSalarioNeto;
        private Label txtTotalDeducciones;
        private PictureBox pictureBox1;
    }
}