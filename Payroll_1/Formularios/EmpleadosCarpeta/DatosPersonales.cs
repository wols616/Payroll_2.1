using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_1.Modelos;
namespace Payroll_1.Formularios.Empleado
{
    public partial class DatosPersonales : Form
    {
        int id_Empleado;
        Empleados Empleado;
        string contraseña;
        string correo_original;
        string cuenta_original;
        string dui_original;
        string telefono_original;
        string nombre_original;
        string apellido_original;
        string direccion_original;

        public DatosPersonales(int id_empleado)
        {
            InitializeComponent();
            lbl_message.Visible = false;
            lbl_contra_nueva.Visible = false;
            lbl_confirmar_contra.Visible = false;
            txt_confirmar_contrasena.Visible = false;
            txt_contrasena_nueva.Visible = false;
            btn_no_cambiar.Visible = false;
            id_Empleado = id_empleado;
            cargarDatos();
        }

        private void cargarDatos()
        {
            Empleado = new Empleados(); // Se crea una instancia de Empleados
            Empleado = Empleado.ObtenerEmpleadoPorId(id_Empleado); // Se obtiene el empleado

            if (Empleado != null)
            {
                txt_dui.Text = Empleado.Dui;
                txt_nombres.Text = Empleado.Nombre;
                txt_apellidos.Text = Empleado.Apellidos;
                txt_telefono.Text = Empleado.Telefono;
                txt_direccion.Text = Empleado.Direccion;
                txt_contrasena_nueva.Text = Empleado.Contrasena;
                txt_confirmar_contrasena.Text = Empleado.Contrasena;
                txt_correo.Text = Empleado.Correo;
                txt_cuenta.Text = FormatearCuenta(Empleado.CuentaCorriente);
                contraseña = Empleado.Contrasena;
                correo_original = Empleado.Correo;
                cuenta_original = Empleado.CuentaCorriente;
                dui_original = Empleado.Dui;
                telefono_original = Empleado.Telefono;
                nombre_original = Empleado.Nombre;
                apellido_original = Empleado.Apellidos;
                direccion_original = Empleado.Direccion;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeEmpleado frm = new HomeEmpleado();
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_actualizar2_click(object sender, EventArgs e)
        {
            string contrasenaNueva = txt_contrasena_nueva.Text.Trim();
            string contrasenaNuevaConfirmar = txt_confirmar_contrasena.Text.Trim();
            string correo = txt_correo.Text.Trim();
            //string cuentaBancaria = txt_cuenta.Text.Trim();

            string cuentaBancaria = new string(txt_cuenta.Text.Trim().Where(char.IsDigit).ToArray());


            string contrasena = txt_contrasena.Text.Trim();

            // Expresiones regulares para validar correo y cuenta bancaria
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Formato de correo válido
            string cuentaBancariaPattern = @"^\d+$"; // Solo números


            if (string.IsNullOrEmpty(correo) && string.IsNullOrEmpty(cuentaBancaria)
                && string.IsNullOrEmpty(contrasena) && string.IsNullOrEmpty(contrasenaNueva)
                && string.IsNullOrEmpty(contrasenaNuevaConfirmar))
            {
                MostrarMensaje("¡Error! Todos los campos están vacíos.");
                lbl_contra_nueva.ForeColor = Color.DarkRed;
                lbl_confirmar_contra.ForeColor = Color.DarkRed;
                lbl_correo.ForeColor = Color.DarkRed;
                lbl_cuenta.ForeColor = Color.DarkRed;
                lbl_contrasena_actual.ForeColor = Color.DarkRed;
                return;
            }
            if (string.IsNullOrEmpty(contrasena))
            {
                MostrarMensaje("La contraseña actual no puede estar vacía.");
                lbl_contrasena_actual.ForeColor = Color.DarkRed;
                return;
            }

            if (string.IsNullOrEmpty(contrasenaNueva))
            {
                MostrarMensaje("La nueva contraseña no puede estar vacía.");
                lbl_contra_nueva.ForeColor = Color.DarkRed;
                return;
            }
            else if (!IsValidPassword(contrasenaNueva))
            {
                MostrarMensaje("La nueva contraseña debe contener al menos una letra, un número y un símbolo.");
                lbl_contra_nueva.ForeColor = Color.DarkRed;
                return;
            }

            if (string.IsNullOrEmpty(contrasenaNuevaConfirmar))
            {
                MostrarMensaje("Debe confirmar la nueva contraseña.");
                lbl_confirmar_contra.ForeColor = Color.DarkRed;
                return;
            }
            else if (contrasenaNueva != contrasenaNuevaConfirmar)
            {
                MostrarMensaje("Las contraseñas no coinciden.");
                lbl_contra_nueva.ForeColor = Color.DarkRed;
                lbl_confirmar_contra.ForeColor = Color.DarkRed;
                return;
            }

            if (string.IsNullOrEmpty(correo))
            {
                MostrarMensaje("El correo no puede estar vacío.");
                lbl_correo.ForeColor = Color.DarkRed;
                return;
            }
            else if (!Regex.IsMatch(correo, emailPattern))
            {
                MostrarMensaje("El correo debe tener un formato válido (ejemplo@dominio.com).");
                lbl_correo.ForeColor = Color.DarkRed;
                return;
            }

            if (string.IsNullOrEmpty(cuentaBancaria))
            {
                MostrarMensaje("La cuenta bancaria no puede estar vacía.");
                lbl_cuenta.ForeColor = Color.DarkRed;
                return;
            }
            else if (!Regex.IsMatch(cuentaBancaria, cuentaBancariaPattern))
            {
                MostrarMensaje("La cuenta bancaria solo debe contener números.");
                lbl_cuenta.ForeColor = Color.DarkRed;
                return;
            }
            else if (txt_contrasena.Text != contraseña)
            {
                MostrarMensaje("La contraseña actual es erronea, para realizar cambios de informacion sensible se requiere su contraseña actual, si no la recuerda, contactese con un administrador");
                lbl_contrasena_actual.ForeColor = Color.DarkRed;
                return;
            }
            else if (txt_correo.Text != correo_original)
            {
                Empleado = new Empleados();
                string correofinal = txt_correo.Text;
                if (Empleado.EsCorreoUnico(correofinal))
                {

                    if (cuentaBancaria != cuenta_original)
                    {
                        string cuentafinal = cuentaBancaria;
                        if (Empleado.EsCuentaUnica(cuentafinal))
                        {
                            //hacer update
                            Empleado = new Empleados();
                            Empleado.ActualizarDatosSensibles(id_Empleado, txt_confirmar_contrasena.Text, txt_correo.Text, cuentaBancaria);
                            MostrarMensajepositivo("Actualizacion realizada");
                            cargarDatos();
                            lbl_contra_nueva.Visible = false;
                            lbl_confirmar_contra.Visible = false;
                            txt_confirmar_contrasena.Visible = false;
                            txt_contrasena_nueva.Visible = false;
                            btn_habilitar_cambio.Visible = true;
                            btn_no_cambiar.Visible = false;
                            txt_contrasena_nueva.Text = contraseña;
                            txt_confirmar_contrasena.Text = contraseña;
                            lbl_contra_nueva.ForeColor = Color.Black;
                            lbl_confirmar_contra.ForeColor = Color.Black;
                            lbl_correo.ForeColor = Color.Black;
                            lbl_cuenta.ForeColor = Color.Black;
                            lbl_contrasena_actual.ForeColor = Color.Black;
                            return;
                        }
                        else
                        {
                            MostrarMensaje("La cuenta bancaria ingresada ya esta siendo usada");
                            lbl_cuenta.ForeColor = Color.DarkRed;
                            return;
                        }
                    }
                    //hacer update
                    Empleado = new Empleados();
                    Empleado.ActualizarDatosSensibles(id_Empleado, txt_confirmar_contrasena.Text, txt_correo.Text, cuentaBancaria);
                    MostrarMensajepositivo("Actualizacion realizada");
                    cargarDatos();
                    lbl_contra_nueva.Visible = false;
                    lbl_confirmar_contra.Visible = false;
                    txt_confirmar_contrasena.Visible = false;
                    txt_contrasena_nueva.Visible = false;
                    btn_habilitar_cambio.Visible = true;
                    btn_no_cambiar.Visible = false;
                    txt_contrasena_nueva.Text = contraseña;
                    txt_confirmar_contrasena.Text = contraseña;
                    lbl_contra_nueva.ForeColor = Color.Black;
                    lbl_confirmar_contra.ForeColor = Color.Black;
                    lbl_correo.ForeColor = Color.Black;
                    lbl_cuenta.ForeColor = Color.Black;
                    lbl_contrasena_actual.ForeColor = Color.Black;
                    return;
                }
                else
                {
                    MostrarMensaje("El correo ingresado ya esta siendo usado");
                    lbl_correo.ForeColor = Color.DarkRed;

                    return;
                }

            }
            else if (cuentaBancaria != cuenta_original)
            {
                string cuentafinal = cuentaBancaria;
                Empleado = new Empleados();
                if (Empleado.EsCuentaUnica(cuentafinal))
                {
                    //hacer update
                    Empleado = new Empleados();
                    Empleado.ActualizarDatosSensibles(id_Empleado, txt_confirmar_contrasena.Text, txt_correo.Text, cuentaBancaria);
                    MostrarMensajepositivo("Actualizacion realizada");
                    cargarDatos();
                    lbl_contra_nueva.Visible = false;
                    lbl_confirmar_contra.Visible = false;
                    txt_confirmar_contrasena.Visible = false;
                    txt_contrasena_nueva.Visible = false;
                    btn_habilitar_cambio.Visible = true;
                    btn_no_cambiar.Visible = false;
                    txt_contrasena_nueva.Text = contraseña;
                    txt_confirmar_contrasena.Text = contraseña;
                    lbl_contra_nueva.ForeColor = Color.Black;
                    lbl_confirmar_contra.ForeColor = Color.Black;
                    lbl_correo.ForeColor = Color.Black;
                    lbl_cuenta.ForeColor = Color.Black;
                    lbl_contrasena_actual.ForeColor = Color.Black;
                    return;
                }
                else
                {
                    MostrarMensaje("La cuenta bancaria ingresada ya esta siendo usada");
                    lbl_cuenta.ForeColor = Color.DarkRed;
                    return;
                }
            }
            else if (txt_contrasena_nueva.Text != contraseña)
            {
                //hacer update
                
                Empleado = new Empleados();
                Empleado.ActualizarDatosSensibles(id_Empleado, txt_confirmar_contrasena.Text, txt_correo.Text, cuentaBancaria);
                MostrarMensajepositivo("Actualizacion realizada");
                cargarDatos();
                lbl_contra_nueva.Visible = false;
                lbl_confirmar_contra.Visible = false;
                txt_confirmar_contrasena.Visible = false;
                txt_contrasena_nueva.Visible = false;
                btn_habilitar_cambio.Visible = true;
                btn_no_cambiar.Visible = false;
                txt_contrasena_nueva.Text = contraseña;
                txt_confirmar_contrasena.Text = contraseña;
                lbl_contra_nueva.ForeColor = Color.Black;
                lbl_confirmar_contra.ForeColor = Color.Black;
                lbl_correo.ForeColor = Color.Black;
                lbl_cuenta.ForeColor = Color.Black;
                lbl_contrasena_actual.ForeColor = Color.Black;
                return;
            }

            MostrarMensajepositivo("No hay cambios que realizar");
            lbl_contra_nueva.ForeColor = Color.Black;
            lbl_confirmar_contra.ForeColor = Color.Black;
            lbl_correo.ForeColor = Color.Black;
            lbl_cuenta.ForeColor = Color.Black;
            lbl_contrasena_actual.ForeColor = Color.Black;
        }

        private void btn_actualizar1_click(object sender, EventArgs e)
        {
            string dui = txt_dui.Text.Trim();
            string nombre = txt_nombres.Text.Trim();
            string apellido = txt_apellidos.Text.Trim();
            string telefono = txt_telefono.Text.Trim();
            string direccion = txt_direccion.Text.Trim();

            string duiPattern = @"^\d{8}-\d$";
            string telefonoPattern = @"^\d{4}-\d{4}$";

            if (string.IsNullOrEmpty(dui) && string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido)
                && string.IsNullOrEmpty(telefono) && string.IsNullOrEmpty(direccion))
            {
                MostrarMensaje("¡Error! Todos los campos están vacíos.");
                lbl_apellidos.ForeColor = Color.DarkRed;
                lbl_dui.ForeColor = Color.DarkRed;
                lbl_nombres.ForeColor = Color.DarkRed;
                lbl_telefono.ForeColor = Color.DarkRed;
                lbl_direccion.ForeColor = Color.DarkRed;
                return;
            }

            else if (string.IsNullOrEmpty(dui))
            {
                MostrarMensaje("El DUI no puede estar vacío.");
                lbl_dui.ForeColor = Color.DarkRed;
                return;
            }

            else if (!Regex.IsMatch(dui, duiPattern))
            {
                MostrarMensaje("El DUI debe tener el formato 12345678-9.");
                lbl_dui.ForeColor = Color.DarkRed;
                return;
            }

            else if (string.IsNullOrEmpty(nombre))
            {
                MostrarMensaje("El nombre no puede estar vacío.");
                lbl_nombres.ForeColor = Color.DarkRed;
                return;
            }

            else if (string.IsNullOrEmpty(apellido))
            {
                MostrarMensaje("El apellido no puede estar vacío.");
                lbl_apellidos.ForeColor = Color.DarkRed;
                return;
            }

            else if (string.IsNullOrEmpty(telefono))
            {
                MostrarMensaje("El teléfono no puede estar vacío.");
                lbl_telefono.ForeColor = Color.DarkRed;
                return;
            }
            else if (!Regex.IsMatch(telefono, telefonoPattern))
            {
                MostrarMensaje("El teléfono debe tener el formato 7777-7777.");
                lbl_telefono.ForeColor = Color.DarkRed;
                return;
            }

            else if (string.IsNullOrEmpty(direccion))
            {
                MostrarMensaje("La dirección no puede estar vacía.");
                lbl_direccion.ForeColor = Color.DarkRed;
                return;
            }

            else if (dui_original != txt_dui.Text)
            {
                Empleado = new Empleados();
                string duiFinal = txt_dui.Text;
                if (Empleado.EsDUIUnico(duiFinal))
                {
                    if (txt_telefono.Text != telefono_original)
                    {
                        string telefonoFinal = txt_telefono.Text;
                        if (Empleado.EsTelefonoUnico(telefonoFinal))
                        {
                            //hacer insercion
                            Empleado = new Empleados();
                            Empleado.ActualizarDatosGenerales(id_Empleado, txt_dui.Text, txt_nombres.Text, txt_apellidos.Text, txt_telefono.Text, txt_direccion.Text);
                            MostrarMensajepositivo("Actualizacion realizada");
                            lbl_apellidos.ForeColor = Color.Black;
                            lbl_dui.ForeColor = Color.Black;
                            lbl_nombres.ForeColor = Color.Black;
                            lbl_telefono.ForeColor = Color.Black;
                            lbl_direccion.ForeColor = Color.Black;
                            cargarDatos();
                            lbl_contra_nueva.Visible = false;
                            lbl_confirmar_contra.Visible = false;
                            txt_confirmar_contrasena.Visible = false;
                            txt_contrasena_nueva.Visible = false;
                            btn_habilitar_cambio.Visible = true;
                            btn_no_cambiar.Visible = false;
                            txt_contrasena_nueva.Text = contraseña;
                            txt_confirmar_contrasena.Text = contraseña;
                            return;
                        }
                        else
                        {
                            MostrarMensaje("El telefono ingresado ya esta siendo usado");
                            lbl_telefono.ForeColor = Color.DarkRed;
                            return;
                        }
                    }
                    //hacer insercion
                    Empleado = new Empleados();
                    Empleado.ActualizarDatosGenerales(id_Empleado, txt_dui.Text, txt_nombres.Text, txt_apellidos.Text, txt_telefono.Text, txt_direccion.Text);
                    MostrarMensajepositivo("Actualizacion realizada");
                    lbl_apellidos.ForeColor = Color.Black;
                    lbl_dui.ForeColor = Color.Black;
                    lbl_nombres.ForeColor = Color.Black;
                    lbl_telefono.ForeColor = Color.Black;
                    lbl_direccion.ForeColor = Color.Black;
                    cargarDatos();
                    lbl_contra_nueva.Visible = false;
                    lbl_confirmar_contra.Visible = false;
                    txt_confirmar_contrasena.Visible = false;
                    txt_contrasena_nueva.Visible = false;
                    btn_habilitar_cambio.Visible = true;
                    btn_no_cambiar.Visible = false;
                    txt_contrasena_nueva.Text = contraseña;
                    txt_confirmar_contrasena.Text = contraseña;
                    return;
                }
                else
                {
                    MostrarMensaje("El dui ingresado ya esta siendo usado");
                    lbl_dui.ForeColor = Color.DarkRed;
                    return;
                }


            }

            if (nombre_original != txt_nombres.Text || apellido_original != txt_apellidos.Text || direccion_original != txt_direccion.Text)
            {
                Empleado = new Empleados();
                Empleado.ActualizarDatosGenerales(id_Empleado, txt_dui.Text, txt_nombres.Text, txt_apellidos.Text, txt_telefono.Text, txt_direccion.Text);
                MostrarMensajepositivo("Actualizacion realizada");
                lbl_apellidos.ForeColor = Color.Black;
                lbl_dui.ForeColor = Color.Black;
                lbl_nombres.ForeColor = Color.Black;
                lbl_telefono.ForeColor = Color.Black;
                lbl_direccion.ForeColor = Color.Black;
                cargarDatos();
                lbl_contra_nueva.Visible = false;
                lbl_confirmar_contra.Visible = false;
                txt_confirmar_contrasena.Visible = false;
                txt_contrasena_nueva.Visible = false;
                btn_habilitar_cambio.Visible = true;
                btn_no_cambiar.Visible = false;
                txt_contrasena_nueva.Text = contraseña;
                txt_confirmar_contrasena.Text = contraseña;
                return;
            }

            if (txt_telefono.Text != telefono_original)
            {
                string telefonoFinal = txt_telefono.Text;
                if (Empleado.EsTelefonoUnico(telefonoFinal))
                {
                    //hacer insercion
                    Empleado = new Empleados();
                    Empleado.ActualizarDatosGenerales(id_Empleado, txt_dui.Text, txt_nombres.Text, txt_apellidos.Text, txt_telefono.Text, txt_direccion.Text);
                    MostrarMensajepositivo("Actualizacion realizada");
                    lbl_apellidos.ForeColor = Color.Black;
                    lbl_dui.ForeColor = Color.Black;
                    lbl_nombres.ForeColor = Color.Black;
                    lbl_telefono.ForeColor = Color.Black;
                    lbl_direccion.ForeColor = Color.Black;
                    cargarDatos();
                    lbl_contra_nueva.Visible = false;
                    lbl_confirmar_contra.Visible = false;
                    txt_confirmar_contrasena.Visible = false;
                    txt_contrasena_nueva.Visible = false;
                    btn_habilitar_cambio.Visible = true;
                    btn_no_cambiar.Visible = false;
                    txt_contrasena_nueva.Text = contraseña;
                    txt_confirmar_contrasena.Text = contraseña;
                    return;
                }
                else
                {
                    MostrarMensaje("El telefono ingresado ya esta siendo usado");
                    lbl_telefono.ForeColor = Color.DarkRed;

                    return;
                }
            }

            MostrarMensajepositivo("No hay cambios que realizar");
            lbl_apellidos.ForeColor = Color.Black;
            lbl_dui.ForeColor = Color.Black;
            lbl_nombres.ForeColor = Color.Black;
            lbl_telefono.ForeColor = Color.Black;
            lbl_direccion.ForeColor = Color.Black;

        }

        private void MostrarMensaje(string mensaje)
        {
            lbl_message.Text = mensaje;
            lbl_message.BackColor = Color.LightCoral;
            lbl_message.ForeColor = Color.DarkRed;
            lbl_message.Visible = true;
        }

        private void MostrarMensajepositivo(string mensaje)
        {
            lbl_message.Text = mensaje;
            lbl_message.BackColor = Color.LightGreen; // Color de fondo verde claro
            lbl_message.ForeColor = Color.DarkGreen; // Color de texto verde oscuro
            lbl_message.Visible = true;
        }


        private bool IsValidPassword(string password)
        {

            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;


                if (hasLetter && hasDigit && hasSpecialChar)
                {
                    return true;
                }
            }

            return hasLetter && hasDigit && hasSpecialChar;
        }

        private void btn_habilitar_cambio_contrasena_click(object sender, EventArgs e)
        {
            lbl_contra_nueva.Visible = true;
            lbl_confirmar_contra.Visible = true;
            txt_confirmar_contrasena.Visible = true;
            txt_contrasena_nueva.Visible = true;
            btn_habilitar_cambio.Visible = false;
            btn_no_cambiar.Visible = true;
            txt_contrasena_nueva.Text = string.Empty;
            txt_confirmar_contrasena.Text = string.Empty;


        }

        private void btn_no_cambiar_click(object sender, EventArgs e)
        {
            lbl_contra_nueva.Visible = false;
            lbl_confirmar_contra.Visible = false;
            txt_confirmar_contrasena.Visible = false;
            txt_contrasena_nueva.Visible = false;
            btn_habilitar_cambio.Visible = true;
            btn_no_cambiar.Visible = false;
            txt_contrasena_nueva.Text = contraseña;
            txt_confirmar_contrasena.Text = contraseña;

        }

        public string FormatearCuenta(string cuenta)
        {
            // Verificar que la cuenta tenga exactamente 12 dígitos
            if (cuenta.Length != 12 || !cuenta.All(char.IsDigit))
            {
                MostrarMensaje("Al parecer su numero de cuenta esta mal en la base de datos, esta debe contener exactamente 12 dígitos numéricos, por favor, corrijala..");
            }
            else
            {
                // Aplicar el formato 00-00-0000000-0
                return $"{cuenta.Substring(0, 2)}-{cuenta.Substring(2, 2)}-{cuenta.Substring(4, 7)}-{cuenta.Substring(11, 1)}";
            }

            return "00-00-0000000-0";
        }
    }
}
