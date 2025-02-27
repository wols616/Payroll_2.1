namespace Payroll_1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeducciones = new Button();
            btnAsignarDeducciones = new Button();
            button1 = new Button();
            btn_contracts = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnDeducciones
            // 
            btnDeducciones.Location = new Point(399, 441);
            btnDeducciones.Margin = new Padding(3, 4, 3, 4);
            btnDeducciones.Name = "btnDeducciones";
            btnDeducciones.Size = new Size(168, 31);
            btnDeducciones.TabIndex = 0;
            btnDeducciones.Text = "Agregar Deducciones";
            btnDeducciones.UseVisualStyleBackColor = true;
            btnDeducciones.Click += btnDeducciones_Click;
            // 
            // btnAsignarDeducciones
            // 
            btnAsignarDeducciones.Location = new Point(399, 384);
            btnAsignarDeducciones.Margin = new Padding(3, 4, 3, 4);
            btnAsignarDeducciones.Name = "btnAsignarDeducciones";
            btnAsignarDeducciones.Size = new Size(168, 31);
            btnAsignarDeducciones.TabIndex = 1;
            btnAsignarDeducciones.Text = "Nomina";
            btnAsignarDeducciones.UseVisualStyleBackColor = true;
            btnAsignarDeducciones.Click += btnAsignarDeducciones_Click;
            // 
            // button1
            // 
            button1.Location = new Point(399, 321);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 31);
            button1.TabIndex = 2;
            button1.Text = "Agregar Empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_contracts
            // 
            btn_contracts.Location = new Point(399, 129);
            btn_contracts.Name = "btn_contracts";
            btn_contracts.Size = new Size(168, 29);
            btn_contracts.TabIndex = 3;
            btn_contracts.Text = "Gestionar contratos";
            btn_contracts.UseVisualStyleBackColor = true;
            btn_contracts.Click += btn_contrats_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 262);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(168, 31);
            button2.TabIndex = 4;
            button2.Text = "Agregar Categoria";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(btn_contracts);
            Controls.Add(button1);
            Controls.Add(btnAsignarDeducciones);
            Controls.Add(btnDeducciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeducciones;
        private Button btnAsignarDeducciones;
        private Button button1;
        private Button btn_contracts;
        private Button button2;
    }
}
