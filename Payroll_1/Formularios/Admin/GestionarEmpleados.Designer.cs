namespace Payroll_1.Formularios
{
    partial class GestionarEmpleados
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
            txt_DUI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ncuenta = new TextBox();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Apellidos = new TextBox();
            txt_Nombre = new TextBox();
            btn_Guardar = new Button();
            btn_Modificar = new Button();
            dgvEmpleados = new DataGridView();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtContrasena = new TextBox();
            label8 = new Label();
            btnGenerarContrasena = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_reporte = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_DUI
            // 
            txt_DUI.Location = new Point(287, 96);
            txt_DUI.Name = "txt_DUI";
            txt_DUI.Size = new Size(291, 27);
            txt_DUI.TabIndex = 0;
            txt_DUI.TextChanged += txt_DUI_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(60, 101);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "DUI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(60, 426);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 7;
            label2.Text = "N° Cuenta Corriente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(60, 358);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(60, 293);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(60, 232);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 10;
            label5.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(60, 160);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // txt_Ncuenta
            // 
            txt_Ncuenta.Location = new Point(287, 420);
            txt_Ncuenta.Name = "txt_Ncuenta";
            txt_Ncuenta.Size = new Size(291, 27);
            txt_Ncuenta.TabIndex = 12;
            txt_Ncuenta.TextChanged += txt_Ncuenta_TextChanged;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(287, 352);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(291, 27);
            txt_Direccion.TabIndex = 13;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(287, 286);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(291, 27);
            txt_Telefono.TabIndex = 14;
            txt_Telefono.TextChanged += txt_Telefono_TextChanged;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(287, 224);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(291, 27);
            txt_Apellidos.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(287, 158);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(291, 27);
            txt_Nombre.TabIndex = 16;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(135, 115, 238);
            btn_Guardar.FlatAppearance.BorderSize = 0;
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(49, 661);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(147, 45);
            btn_Guardar.TabIndex = 17;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += button1_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.FromArgb(135, 115, 238);
            btn_Modificar.FlatAppearance.BorderSize = 0;
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_Modificar.ForeColor = Color.White;
            btn_Modificar.Location = new Point(231, 661);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(147, 45);
            btn_Modificar.TabIndex = 18;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += button2_Click;
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(183, 171, 240);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(90, 63, 230);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.Location = new Point(21, 53);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1167, 609);
            dgvEmpleados.TabIndex = 19;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(287, 494);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(291, 27);
            txtCorreo.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(60, 501);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 22;
            label7.Text = "Correo:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(287, 572);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(291, 27);
            txtContrasena.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(60, 578);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 24;
            label8.Text = "Contraseña:";
            // 
            // btnGenerarContrasena
            // 
            btnGenerarContrasena.BackColor = Color.FromArgb(135, 115, 238);
            btnGenerarContrasena.FlatAppearance.BorderSize = 0;
            btnGenerarContrasena.FlatStyle = FlatStyle.Flat;
            btnGenerarContrasena.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarContrasena.ForeColor = Color.White;
            btnGenerarContrasena.Location = new Point(190, 572);
            btnGenerarContrasena.Margin = new Padding(3, 4, 3, 4);
            btnGenerarContrasena.Name = "btnGenerarContrasena";
            btnGenerarContrasena.Size = new Size(86, 31);
            btnGenerarContrasena.TabIndex = 26;
            btnGenerarContrasena.Text = "Generar";
            btnGenerarContrasena.UseVisualStyleBackColor = false;
            btnGenerarContrasena.Click += btnGenerarContrasena_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvEmpleados);
            panel1.Location = new Point(596, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 687);
            panel1.TabIndex = 27;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(21, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_reporte
            // 
            btn_reporte.BackColor = Color.FromArgb(135, 115, 238);
            btn_reporte.FlatAppearance.BorderSize = 0;
            btn_reporte.FlatStyle = FlatStyle.Flat;
            btn_reporte.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_reporte.ForeColor = Color.White;
            btn_reporte.Location = new Point(416, 661);
            btn_reporte.Name = "btn_reporte";
            btn_reporte.Size = new Size(147, 45);
            btn_reporte.TabIndex = 29;
            btn_reporte.Text = "Reporte";
            btn_reporte.UseVisualStyleBackColor = false;
            btn_reporte.Click += btn_reporte_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(489, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1835, 735);
            Controls.Add(pictureBox2);
            Controls.Add(btn_reporte);
            Controls.Add(btnGenerarContrasena);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txt_Direccion);
            Controls.Add(txtContrasena);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_DUI);
            Controls.Add(txt_Ncuenta);
            Controls.Add(label8);
            Controls.Add(txt_Apellidos);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(txt_Nombre);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(btn_Guardar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_Modificar);
            Name = "GestionarEmpleados";
            Text = "agregarEmpleado";
            Load += agregarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DUI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ncuenta;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Apellidos;
        private TextBox txt_Nombre;
        private Button btn_Guardar;
        private Button btn_Modificar;
        private DataGridView dgvEmpleados;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtContrasena;
        private Label label8;
        private Button btnGenerarContrasena;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_reporte;
        private PictureBox pictureBox2;
    }
}