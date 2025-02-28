using Payroll_1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios
{
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPasswordVisible)
            {
                pictureBox1.Image = Properties.Resources.eye;
                txtContrasena.UseSystemPasswordChar = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.eye_fill;
                txtContrasena.UseSystemPasswordChar = false;
            }

            isPasswordVisible = !isPasswordVisible;

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;


            if (string.IsNullOrEmpty(correo) && string.IsNullOrEmpty(contrasena))
            {
                MostrarMensaje("El correo y la contraseña no pueden estar vacíos.");
                lbl_error.Visible = true;
                return;
            }
            else if (string.IsNullOrEmpty(correo))
            {
                MostrarMensaje("El correo no puede estar vacío.");
                lbl_error.Visible = true;
                return;
            }
            else if (!IsValidEmail(correo))
            {
                MostrarMensaje("El correo no tiene un formato válido.");
                lbl_error.Visible = true;
                return;
            }
            else if (string.IsNullOrEmpty(contrasena))
            {
                MostrarMensaje("La contraseña no puede estar vacía.");
                lbl_error.Visible = true;
                return;
            }
            else if (!IsValidPassword(contrasena))
            {
                MostrarMensaje(" Formato invalido, la contraseña debe tener al menos una letra, un número y un símbolo.");
                lbl_error.Visible = true;
                return;
            }
            else
            {
                MostrarMensaje("Credenciales invalidas, usuario no encontrado");
                lbl_error.Visible = true;
            }

            if (checkBoxAdmin.Checked)
            {
                Administrador administrador = new Administrador();
                int id_administrador = administrador.LoginAdministrador(correo, contrasena);

                if (id_administrador != -1)
                {
                    HomeAdmin frm = new HomeAdmin();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    //Credenciales invalidas
                }
            }
            else
            {
                Empleados empleado = new Empleados();
                int id_empleado = empleado.LoginEmpleado(correo, contrasena);

                if (id_empleado != -1)
                {
                    HomeEmpleado frm = new HomeEmpleado();
                    frm.Show();
                    this.Hide();
                }
                else { 
                    //Credenciales invalidas

                }

            }
        }

        private bool IsValidPassword(string password)
        {
            // Verificar si la contraseña contiene al menos una letra, un número y un símbolo
            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;

                // Si ya tiene los 3 elementos, no es necesario seguir iterando
                if (hasLetter && hasDigit && hasSpecialChar)
                {
                    return true;
                }
            }

            return hasLetter && hasDigit && hasSpecialChar;
        }

        private bool IsValidEmail(string email)
        {
            // Expresión regular para verificar el formato del correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        public void MostrarMensaje(string mensaje)
        {
            lbl_error.Text = mensaje;
            lbl_error.BackColor = Color.LightCoral;
            lbl_error.ForeColor = Color.DarkRed;
            lbl_error.Visible = true;
        }

    }
}
