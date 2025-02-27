namespace Payroll_1.Formularios.Empleado
{
    partial class DatosPersonales
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_direccion = new TextBox();
            txt_telefono = new TextBox();
            txt_apellidos = new TextBox();
            txt_nombres = new TextBox();
            btn_actualizar_personales = new Button();
            lbl_direccion = new Label();
            lbl_telefono = new Label();
            lbl_apellidos = new Label();
            lbl_nombres = new Label();
            txt_dui = new TextBox();
            lbl_dui = new Label();
            groupBox2 = new GroupBox();
            btn_no_cambiar = new Button();
            btn_habilitar_cambio = new Button();
            txt_confirmar_contrasena = new TextBox();
            lbl_confirmar_contra = new Label();
            txt_contrasena_nueva = new TextBox();
            txt_correo = new TextBox();
            txt_cuenta = new TextBox();
            lbl_cuenta = new Label();
            lbl_correo = new Label();
            lbl_contra_nueva = new Label();
            txt_contrasena = new TextBox();
            btn_actualizar_sensibles = new Button();
            lbl_contrasena_actual = new Label();
            lbl_message = new Label();
            lbl_id = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 36);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 31;
            label1.Text = "Datos personales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txt_direccion);
            groupBox1.Controls.Add(txt_telefono);
            groupBox1.Controls.Add(txt_apellidos);
            groupBox1.Controls.Add(txt_nombres);
            groupBox1.Controls.Add(btn_actualizar_personales);
            groupBox1.Controls.Add(lbl_direccion);
            groupBox1.Controls.Add(lbl_telefono);
            groupBox1.Controls.Add(lbl_apellidos);
            groupBox1.Controls.Add(lbl_nombres);
            groupBox1.Controls.Add(txt_dui);
            groupBox1.Controls.Add(lbl_dui);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 447);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información general";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Segoe UI", 9F);
            txt_direccion.Location = new Point(118, 285);
            txt_direccion.Multiline = true;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(248, 58);
            txt_direccion.TabIndex = 10;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Segoe UI", 9F);
            txt_telefono.Location = new Point(118, 225);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(248, 27);
            txt_telefono.TabIndex = 9;
            // 
            // txt_apellidos
            // 
            txt_apellidos.Font = new Font("Segoe UI", 9F);
            txt_apellidos.Location = new Point(118, 170);
            txt_apellidos.Name = "txt_apellidos";
            txt_apellidos.Size = new Size(248, 27);
            txt_apellidos.TabIndex = 8;
            // 
            // txt_nombres
            // 
            txt_nombres.Font = new Font("Segoe UI", 9F);
            txt_nombres.Location = new Point(118, 110);
            txt_nombres.Name = "txt_nombres";
            txt_nombres.Size = new Size(248, 27);
            txt_nombres.TabIndex = 7;
            // 
            // btn_actualizar_personales
            // 
            btn_actualizar_personales.AccessibleRole = AccessibleRole.None;
            btn_actualizar_personales.BackColor = Color.FromArgb(135, 115, 238);
            btn_actualizar_personales.FlatStyle = FlatStyle.Flat;
            btn_actualizar_personales.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_actualizar_personales.ForeColor = Color.White;
            btn_actualizar_personales.Location = new Point(62, 384);
            btn_actualizar_personales.Name = "btn_actualizar_personales";
            btn_actualizar_personales.Size = new Size(275, 42);
            btn_actualizar_personales.TabIndex = 6;
            btn_actualizar_personales.Text = "Actualizar";
            btn_actualizar_personales.UseVisualStyleBackColor = false;
            btn_actualizar_personales.Click += btn_actualizar1_click;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(34, 288);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(78, 20);
            lbl_direccion.TabIndex = 5;
            lbl_direccion.Text = "Dirección:";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(34, 228);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(74, 20);
            lbl_telefono.TabIndex = 4;
            lbl_telefono.Text = "Telefono:";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.AutoSize = true;
            lbl_apellidos.Location = new Point(34, 170);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new Size(78, 20);
            lbl_apellidos.TabIndex = 3;
            lbl_apellidos.Text = "Apellidos:";
            // 
            // lbl_nombres
            // 
            lbl_nombres.AutoSize = true;
            lbl_nombres.Location = new Point(34, 113);
            lbl_nombres.Name = "lbl_nombres";
            lbl_nombres.Size = new Size(78, 20);
            lbl_nombres.TabIndex = 2;
            lbl_nombres.Text = "Nombres:";
            // 
            // txt_dui
            // 
            txt_dui.Font = new Font("Segoe UI", 9F);
            txt_dui.Location = new Point(80, 49);
            txt_dui.Name = "txt_dui";
            txt_dui.Size = new Size(163, 27);
            txt_dui.TabIndex = 1;
            // 
            // lbl_dui
            // 
            lbl_dui.AutoSize = true;
            lbl_dui.Location = new Point(34, 52);
            lbl_dui.Name = "lbl_dui";
            lbl_dui.Size = new Size(40, 20);
            lbl_dui.TabIndex = 0;
            lbl_dui.Text = "DUI:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_no_cambiar);
            groupBox2.Controls.Add(btn_habilitar_cambio);
            groupBox2.Controls.Add(txt_confirmar_contrasena);
            groupBox2.Controls.Add(lbl_confirmar_contra);
            groupBox2.Controls.Add(txt_contrasena_nueva);
            groupBox2.Controls.Add(txt_correo);
            groupBox2.Controls.Add(txt_cuenta);
            groupBox2.Controls.Add(lbl_cuenta);
            groupBox2.Controls.Add(lbl_correo);
            groupBox2.Controls.Add(lbl_contra_nueva);
            groupBox2.Controls.Add(txt_contrasena);
            groupBox2.Controls.Add(btn_actualizar_sensibles);
            groupBox2.Controls.Add(lbl_contrasena_actual);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(441, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 447);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información sensible";
            // 
            // btn_no_cambiar
            // 
            btn_no_cambiar.AccessibleRole = AccessibleRole.None;
            btn_no_cambiar.BackColor = Color.FromArgb(135, 115, 238);
            btn_no_cambiar.FlatStyle = FlatStyle.Flat;
            btn_no_cambiar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_no_cambiar.ForeColor = Color.White;
            btn_no_cambiar.Location = new Point(93, 128);
            btn_no_cambiar.Name = "btn_no_cambiar";
            btn_no_cambiar.Size = new Size(208, 42);
            btn_no_cambiar.TabIndex = 20;
            btn_no_cambiar.Text = "No cambiar contraseña";
            btn_no_cambiar.UseVisualStyleBackColor = false;
            btn_no_cambiar.Click += btn_no_cambiar_click;
            // 
            // btn_habilitar_cambio
            // 
            btn_habilitar_cambio.AccessibleRole = AccessibleRole.None;
            btn_habilitar_cambio.BackColor = Color.FromArgb(135, 115, 238);
            btn_habilitar_cambio.FlatStyle = FlatStyle.Flat;
            btn_habilitar_cambio.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_habilitar_cambio.ForeColor = Color.White;
            btn_habilitar_cambio.Location = new Point(93, 75);
            btn_habilitar_cambio.Name = "btn_habilitar_cambio";
            btn_habilitar_cambio.Size = new Size(208, 42);
            btn_habilitar_cambio.TabIndex = 19;
            btn_habilitar_cambio.Text = "Cambiar contraseña";
            btn_habilitar_cambio.UseVisualStyleBackColor = false;
            btn_habilitar_cambio.Click += btn_habilitar_cambio_contrasena_click;
            // 
            // txt_confirmar_contrasena
            // 
            txt_confirmar_contrasena.Font = new Font("Segoe UI", 9F);
            txt_confirmar_contrasena.Location = new Point(200, 85);
            txt_confirmar_contrasena.Name = "txt_confirmar_contrasena";
            txt_confirmar_contrasena.Size = new Size(156, 27);
            txt_confirmar_contrasena.TabIndex = 18;
            // 
            // lbl_confirmar_contra
            // 
            lbl_confirmar_contra.AutoSize = true;
            lbl_confirmar_contra.Location = new Point(35, 88);
            lbl_confirmar_contra.Name = "lbl_confirmar_contra";
            lbl_confirmar_contra.Size = new Size(165, 20);
            lbl_confirmar_contra.TabIndex = 17;
            lbl_confirmar_contra.Text = "Confirmar contraseña:";
            // 
            // txt_contrasena_nueva
            // 
            txt_contrasena_nueva.Font = new Font("Segoe UI", 9F);
            txt_contrasena_nueva.Location = new Point(179, 37);
            txt_contrasena_nueva.Name = "txt_contrasena_nueva";
            txt_contrasena_nueva.Size = new Size(156, 27);
            txt_contrasena_nueva.TabIndex = 16;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Segoe UI", 9F);
            txt_correo.Location = new Point(101, 186);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(255, 27);
            txt_correo.TabIndex = 15;
            // 
            // txt_cuenta
            // 
            txt_cuenta.Font = new Font("Segoe UI", 9F);
            txt_cuenta.Location = new Point(166, 237);
            txt_cuenta.Name = "txt_cuenta";
            txt_cuenta.Size = new Size(190, 27);
            txt_cuenta.TabIndex = 11;
            // 
            // lbl_cuenta
            // 
            lbl_cuenta.AutoSize = true;
            lbl_cuenta.Location = new Point(35, 240);
            lbl_cuenta.Name = "lbl_cuenta";
            lbl_cuenta.Size = new Size(125, 20);
            lbl_cuenta.TabIndex = 14;
            lbl_cuenta.Text = "Cuenta bancaria:";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(35, 190);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(60, 20);
            lbl_correo.TabIndex = 13;
            lbl_correo.Text = "Correo:";
            // 
            // lbl_contra_nueva
            // 
            lbl_contra_nueva.AutoSize = true;
            lbl_contra_nueva.Location = new Point(35, 40);
            lbl_contra_nueva.Name = "lbl_contra_nueva";
            lbl_contra_nueva.Size = new Size(138, 20);
            lbl_contra_nueva.TabIndex = 12;
            lbl_contra_nueva.Text = "Contraseña nueva:";
            // 
            // txt_contrasena
            // 
            txt_contrasena.Font = new Font("Segoe UI", 9F);
            txt_contrasena.Location = new Point(35, 317);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(321, 27);
            txt_contrasena.TabIndex = 11;
            // 
            // btn_actualizar_sensibles
            // 
            btn_actualizar_sensibles.AccessibleRole = AccessibleRole.None;
            btn_actualizar_sensibles.BackColor = Color.FromArgb(135, 115, 238);
            btn_actualizar_sensibles.FlatStyle = FlatStyle.Flat;
            btn_actualizar_sensibles.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold);
            btn_actualizar_sensibles.ForeColor = Color.White;
            btn_actualizar_sensibles.Location = new Point(60, 384);
            btn_actualizar_sensibles.Name = "btn_actualizar_sensibles";
            btn_actualizar_sensibles.Size = new Size(275, 42);
            btn_actualizar_sensibles.TabIndex = 11;
            btn_actualizar_sensibles.Text = "Actualizar";
            btn_actualizar_sensibles.UseVisualStyleBackColor = false;
            btn_actualizar_sensibles.Click += btn_actualizar2_click;
            // 
            // lbl_contrasena_actual
            // 
            lbl_contrasena_actual.AutoSize = true;
            lbl_contrasena_actual.Location = new Point(35, 294);
            lbl_contrasena_actual.Name = "lbl_contrasena_actual";
            lbl_contrasena_actual.Size = new Size(321, 20);
            lbl_contrasena_actual.TabIndex = 11;
            lbl_contrasena_actual.Text = "Ingrese su contraseña actual para confirmar:";
            // 
            // lbl_message
            // 
            lbl_message.BackColor = Color.MistyRose;
            lbl_message.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_message.ImageAlign = ContentAlignment.MiddleRight;
            lbl_message.Location = new Point(-8, 578);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(877, 74);
            lbl_message.TabIndex = 34;
            lbl_message.Text = "label11";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(671, 69);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(0, 20);
            lbl_id.TabIndex = 35;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(712, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // DatosPersonales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 649);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_id);
            Controls.Add(lbl_message);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DatosPersonales";
            Text = "EditarDatosPersonales";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label lbl_apellidos;
        private Label lbl_nombres;
        private TextBox txt_dui;
        private Label lbl_dui;
        private GroupBox groupBox2;
        private Button btn_actualizar_personales;
        private Label lbl_direccion;
        private Label lbl_telefono;
        private TextBox txt_telefono;
        private TextBox txt_apellidos;
        private TextBox txt_nombres;
        private Button btn_actualizar_sensibles;
        private Label lbl_contrasena_actual;
        private TextBox txt_cuenta;
        private Label lbl_cuenta;
        private Label lbl_correo;
        private Label lbl_contra_nueva;
        private TextBox txt_contrasena;
        private TextBox txt_contrasena_nueva;
        private TextBox txt_correo;
        private Label lbl_message;
        private TextBox txt_confirmar_contrasena;
        private Label lbl_confirmar_contra;
        private TextBox txt_direccion;
        private Button btn_habilitar_cambio;
        private Button btn_no_cambiar;
        private Label lbl_id;
        private PictureBox pictureBox2;
    }
}