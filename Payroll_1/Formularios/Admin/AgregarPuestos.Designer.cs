namespace Payroll_1.Formularios.Admin
{
    partial class AgregarPuestos
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
            label1 = new Label();
            txtNombrePuesto = new TextBox();
            cbCategoria = new ComboBox();
            label2 = new Label();
            txtSueldoBase = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dgvPuestos = new DataGridView();
            editar = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(128, 416);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del puesto:";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new Point(302, 413);
            txtNombrePuesto.Margin = new Padding(3, 4, 3, 4);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(243, 27);
            txtNombrePuesto.TabIndex = 2;
            txtNombrePuesto.TextChanged += textBox1_TextChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(302, 376);
            cbCategoria.Margin = new Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(243, 28);
            cbCategoria.TabIndex = 3;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(128, 379);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSueldoBase.Location = new Point(558, 377);
            txtSueldoBase.Margin = new Padding(3, 4, 3, 4);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(115, 27);
            txtSueldoBase.TabIndex = 5;
            txtSueldoBase.Text = "Sueldo Base";
            txtSueldoBase.TextChanged += txtSueldoBase_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(135, 115, 238);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(436, 472);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(220, 40);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 16);
            label3.Name = "label3";
            label3.Size = new Size(269, 41);
            label3.TabIndex = 7;
            label3.Text = "Gestor de Puestos";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvPuestos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(183, 171, 240);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(135, 115, 238);
            dgvPuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(90, 63, 230);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.Location = new Point(96, 77);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.Size = new Size(612, 276);
            dgvPuestos.TabIndex = 13;
            dgvPuestos.CellContentClick += dataGridView1_CellContentClick;
            dgvPuestos.SelectionChanged += dvgPuestos_SelectionChanged;
            // 
            // editar
            // 
            editar.BackColor = Color.FromArgb(135, 115, 238);
            editar.FlatAppearance.BorderSize = 0;
            editar.FlatStyle = FlatStyle.Flat;
            editar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            editar.ForeColor = Color.White;
            editar.Location = new Point(164, 472);
            editar.Margin = new Padding(3, 4, 3, 4);
            editar.Name = "editar";
            editar.Size = new Size(220, 40);
            editar.TabIndex = 14;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = false;
            editar.Click += editar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(724, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // AgregarPuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(816, 544);
            Controls.Add(pictureBox2);
            Controls.Add(editar);
            Controls.Add(dgvPuestos);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtSueldoBase);
            Controls.Add(label2);
            Controls.Add(cbCategoria);
            Controls.Add(txtNombrePuesto);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarPuestos";
            Text = "AgregarPuestos";
            Load += AgregarPuestos_Load;
            MouseClick += AgregarPuestos_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePuesto;
        private ComboBox cbCategoria;
        private Label label2;
        private TextBox txtSueldoBase;
        private Button btnAgregar;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dgvPuestos;
        private Button editar;
        private PictureBox pictureBox2;
    }
}