namespace Payroll_1.Formularios.Admin
{
    partial class GestionarPuestoCategoria
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
            btnCategorias = new Button();
            btnGestionarPuestos = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(101, 76, 231);
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(215, 286);
            btnCategorias.Margin = new Padding(3, 4, 3, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(329, 51);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Gestionar Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnGestionarPuestos
            // 
            btnGestionarPuestos.BackColor = Color.FromArgb(135, 115, 238);
            btnGestionarPuestos.FlatAppearance.BorderSize = 0;
            btnGestionarPuestos.FlatStyle = FlatStyle.Flat;
            btnGestionarPuestos.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnGestionarPuestos.ForeColor = Color.White;
            btnGestionarPuestos.Location = new Point(215, 348);
            btnGestionarPuestos.Margin = new Padding(3, 4, 3, 4);
            btnGestionarPuestos.Name = "btnGestionarPuestos";
            btnGestionarPuestos.Size = new Size(329, 51);
            btnGestionarPuestos.TabIndex = 1;
            btnGestionarPuestos.Text = "Gestionar Puestos";
            btnGestionarPuestos.UseVisualStyleBackColor = false;
            btnGestionarPuestos.Click += btnGestionarPuestos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(215, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(329, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // GestionarPuestoCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(765, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnGestionarPuestos);
            Controls.Add(btnCategorias);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionarPuestoCategoria";
            Text = "GestionarPuestoCategoria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private Button btnGestionarPuestos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}