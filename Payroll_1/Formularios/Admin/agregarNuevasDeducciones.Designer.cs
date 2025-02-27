namespace Payroll_1.Formularios
{
    partial class agregarNuevasDeducciones
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
            dgvDeducciones = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtPorcentajee = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(59, 47);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(683, 150);
            dgvDeducciones.TabIndex = 0;
            dgvDeducciones.CellClick += dgvDeducciones_CellClick;
            dgvDeducciones.SelectionChanged += dgvDeducciones_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 226);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 226);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Porcentaje:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 218);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(234, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(353, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(468, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPorcentajee
            // 
            txtPorcentajee.Location = new Point(460, 223);
            txtPorcentajee.Name = "txtPorcentajee";
            txtPorcentajee.Size = new Size(154, 23);
            txtPorcentajee.TabIndex = 8;
            txtPorcentajee.TextChanged += txtPorcentajee_TextChanged;
            txtPorcentajee.KeyPress += txtPorcentajee_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // agregarNuevasDeducciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 335);
            Controls.Add(pictureBox1);
            Controls.Add(txtPorcentajee);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDeducciones);
            Name = "agregarNuevasDeducciones";
            Text = "agregarDeducciones";
            Load += agregarDeducciones_Load;
            MouseClick += agregarNuevasDeducciones_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDeducciones;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtPorcentajee;
        private PictureBox pictureBox1;
    }
}