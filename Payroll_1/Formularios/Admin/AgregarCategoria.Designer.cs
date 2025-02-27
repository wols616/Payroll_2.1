namespace Payroll_1.Formularios
{
    partial class AgregarCategoria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCategoria = new DataGridView();
            agregar = new Button();
            button3 = new Button();
            TxtNombreCat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtSueldoBase = new TextBox();
            btnAgregarPuesto = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(183, 171, 240);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(135, 115, 238);
            dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(90, 63, 230);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategoria.Location = new Point(74, 87);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(561, 269);
            dgvCategoria.TabIndex = 0;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            dgvCategoria.SelectionChanged += dgvCategoria_SelectionChanged;
            // 
            // agregar
            // 
            agregar.BackColor = Color.FromArgb(135, 115, 238);
            agregar.FlatAppearance.BorderSize = 0;
            agregar.FlatStyle = FlatStyle.Flat;
            agregar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            agregar.ForeColor = Color.White;
            agregar.Location = new Point(380, 463);
            agregar.Name = "agregar";
            agregar.Size = new Size(225, 40);
            agregar.TabIndex = 1;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = false;
            agregar.Click += agregar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(135, 115, 238);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(122, 463);
            button3.Name = "button3";
            button3.Size = new Size(220, 40);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TxtNombreCat
            // 
            TxtNombreCat.Location = new Point(289, 379);
            TxtNombreCat.Name = "TxtNombreCat";
            TxtNombreCat.Size = new Size(346, 27);
            TxtNombreCat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(86, 387);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre de la Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(86, 414);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 8;
            label2.Text = "Sueldo Base:";
            // 
            // TxtSueldoBase
            // 
            TxtSueldoBase.Location = new Point(289, 412);
            TxtSueldoBase.Name = "TxtSueldoBase";
            TxtSueldoBase.Size = new Size(179, 27);
            TxtSueldoBase.TabIndex = 9;
            // 
            // btnAgregarPuesto
            // 
            btnAgregarPuesto.BackColor = Color.FromArgb(90, 63, 230);
            btnAgregarPuesto.FlatAppearance.BorderSize = 0;
            btnAgregarPuesto.FlatStyle = FlatStyle.Flat;
            btnAgregarPuesto.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btnAgregarPuesto.ForeColor = Color.White;
            btnAgregarPuesto.Location = new Point(234, 523);
            btnAgregarPuesto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarPuesto.Name = "btnAgregarPuesto";
            btnAgregarPuesto.Size = new Size(249, 40);
            btnAgregarPuesto.TabIndex = 10;
            btnAgregarPuesto.Text = "Puestos";
            btnAgregarPuesto.UseVisualStyleBackColor = false;
            btnAgregarPuesto.Click += btnAgregarPuesto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(16, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(189, 29);
            label3.Name = "label3";
            label3.Size = new Size(319, 41);
            label3.TabIndex = 12;
            label3.Text = "Gestión de Categorias";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(634, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 600);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregarPuesto);
            Controls.Add(TxtSueldoBase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNombreCat);
            Controls.Add(button3);
            Controls.Add(agregar);
            Controls.Add(dgvCategoria);
            Name = "AgregarCategoria";
            Text = "AgregarCategoria";
            Load += AgregarCategoria_Load;
            MouseClick += AgregarCategoria_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private Button agregar;
        private Button button3;
        private TextBox TxtNombreCat;
        private Label label1;
        private Label label2;
        private TextBox TxtSueldoBase;
        private Button btnAgregarPuesto;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}