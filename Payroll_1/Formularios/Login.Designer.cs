namespace Payroll_1.Formularios
{
    partial class Login
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
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            checkBoxAdmin = new CheckBox();
            lbl_error = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 285);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(97, 261);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(351, 27);
            txtCorreo.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtContrasena.Location = new Point(97, 336);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '•';
            txtContrasena.Size = new Size(351, 27);
            txtContrasena.TabIndex = 3;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 342);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(135, 115, 238);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(56, 422);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(405, 46);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(467, 341);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAdmin.Location = new Point(223, 481);
            checkBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(78, 24);
            checkBoxAdmin.TabIndex = 6;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_error
            // 
            lbl_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_error.ForeColor = Color.Firebrick;
            lbl_error.Location = new Point(-5, 557);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(524, 77);
            lbl_error.TabIndex = 7;
            lbl_error.Text = "label3";
            lbl_error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(116, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.email;
            pictureBox3.Location = new Point(56, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.candado;
            pictureBox4.Location = new Point(56, 328);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(135, 115, 238);
            panel1.Location = new Point(56, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 1);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(135, 115, 238);
            panel2.Location = new Point(56, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 1);
            panel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 357);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 14;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 634);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_error);
            Controls.Add(checkBoxAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label label2;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private CheckBox checkBoxAdmin;
        private Label lbl_error;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
    }
}