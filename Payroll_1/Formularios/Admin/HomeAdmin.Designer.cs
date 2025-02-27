namespace Payroll_1.Formularios
{
    partial class HomeAdmin
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
            btnGestionarEmpleados = new Button();
            btnGestionarPuestoCategoria = new Button();
            btnGestionarContratos = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGestionarEmpleados
            // 
            btnGestionarEmpleados.BackColor = Color.FromArgb(90, 63, 230);
            btnGestionarEmpleados.FlatAppearance.BorderSize = 0;
            btnGestionarEmpleados.FlatStyle = FlatStyle.Flat;
            btnGestionarEmpleados.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnGestionarEmpleados.ForeColor = Color.White;
            btnGestionarEmpleados.Location = new Point(228, 237);
            btnGestionarEmpleados.Margin = new Padding(3, 4, 3, 4);
            btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            btnGestionarEmpleados.Size = new Size(329, 51);
            btnGestionarEmpleados.TabIndex = 0;
            btnGestionarEmpleados.Text = "Gestionar Empleados";
            btnGestionarEmpleados.UseVisualStyleBackColor = false;
            btnGestionarEmpleados.Click += btnGestionarEmpleados_Click;
            // 
            // btnGestionarPuestoCategoria
            // 
            btnGestionarPuestoCategoria.BackColor = Color.FromArgb(101, 76, 231);
            btnGestionarPuestoCategoria.FlatAppearance.BorderSize = 0;
            btnGestionarPuestoCategoria.FlatStyle = FlatStyle.Flat;
            btnGestionarPuestoCategoria.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnGestionarPuestoCategoria.ForeColor = Color.White;
            btnGestionarPuestoCategoria.Location = new Point(228, 303);
            btnGestionarPuestoCategoria.Margin = new Padding(3, 4, 3, 4);
            btnGestionarPuestoCategoria.Name = "btnGestionarPuestoCategoria";
            btnGestionarPuestoCategoria.Size = new Size(329, 51);
            btnGestionarPuestoCategoria.TabIndex = 1;
            btnGestionarPuestoCategoria.Text = "Gestionar Puestos y Categorias";
            btnGestionarPuestoCategoria.UseVisualStyleBackColor = false;
            btnGestionarPuestoCategoria.Click += btnGestionarPuestoCategoria_Click;
            // 
            // btnGestionarContratos
            // 
            btnGestionarContratos.BackColor = Color.FromArgb(135, 115, 238);
            btnGestionarContratos.FlatAppearance.BorderSize = 0;
            btnGestionarContratos.FlatStyle = FlatStyle.Flat;
            btnGestionarContratos.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnGestionarContratos.ForeColor = Color.White;
            btnGestionarContratos.Location = new Point(228, 368);
            btnGestionarContratos.Margin = new Padding(3, 4, 3, 4);
            btnGestionarContratos.Name = "btnGestionarContratos";
            btnGestionarContratos.Size = new Size(329, 51);
            btnGestionarContratos.TabIndex = 2;
            btnGestionarContratos.Text = "Gestionar Contratos";
            btnGestionarContratos.UseVisualStyleBackColor = false;
            btnGestionarContratos.Click += btnGestionarContratos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logOut;
            pictureBox1.Location = new Point(701, 393);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(228, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(329, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 459);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnGestionarContratos);
            Controls.Add(btnGestionarPuestoCategoria);
            Controls.Add(btnGestionarEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeAdmin";
            Text = "HomeAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarEmpleados;
        private Button btnGestionarPuestoCategoria;
        private Button btnGestionarContratos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}