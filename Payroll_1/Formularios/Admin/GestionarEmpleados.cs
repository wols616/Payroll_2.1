using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;
using Payroll_1.Modelos;
using System.Text.RegularExpressions;




namespace Payroll_1.Formularios
{
    public partial class GestionarEmpleados : Form
    {
        public GestionarEmpleados()
        {
            InitializeComponent();
        }

        //Payroll_1.Modelos.Empleado empleado = new Payroll_1.Modelos.Empleado();
        Empleados empleado = new Empleados();
        //Empleado empleado = new Empleado();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Contador de validaciones exitosas
                int contadorValidaciones = 0;

                // DUI:
                string dui = txt_DUI.Text;
                if (!empleado.EsDUIUnico(dui))
                {
                    MessageBox.Show("Este DUI ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (dui.Length != 10 || dui[8] != '-' || !dui.Replace("-", "").All(char.IsDigit))
                {
                    MessageBox.Show("El DUI debe tener el formato NNNNNNNNN-N.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_DUI.Text))
                {
                    MessageBox.Show("El campo de DUI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Dui = dui;
                }

                // Nombre
                txt_Nombre.Text = txt_Nombre.Text.TrimEnd();
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Nombre.Text.Length < 2)
                {
                    MessageBox.Show("El campo Nombre debe contener al menos dos caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txt_Nombre.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúÑñ]+)?$"))
                {
                    MessageBox.Show("El campo Nombre solo puede contener letras, no números ni caracteres especiales.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Nombre = txt_Nombre.Text;
                }

                // Apellidos
                txt_Apellidos.Text = txt_Apellidos.Text.TrimEnd();
                if (string.IsNullOrWhiteSpace(txt_Apellidos.Text))
                {
                    MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Apellidos.Text.Length < 2)
                {
                    MessageBox.Show("El campo Apellido debe contener al menos dos caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txt_Apellidos.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúÑñ]+)?$"))
                {
                    MessageBox.Show("El campo Apellido solo puede contener letras, no números ni caracteres especiales.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Apellidos = txt_Apellidos.Text;
                }


                // Dirección
                if (string.IsNullOrWhiteSpace(txt_Direccion.Text) || txt_Direccion.Text.Length < 2 || !txt_Direccion.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("La Dirección debe contener al menos una letra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
                {
                    MessageBox.Show("El campo de Dirección no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Direccion = txt_Direccion.Text;
                }

                // Número de cuenta
                if (string.IsNullOrWhiteSpace(txt_Ncuenta.Text))
                {
                    MessageBox.Show("El campo Cuenta Corriente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txt_Ncuenta.Text.Length != 15)
                {
                    MessageBox.Show("La Cuenta Corriente debe tener exactamente 12 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsCuentaUnica(txt_Ncuenta.Text))
                {
                    MessageBox.Show("Este número de cuenta ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.CuentaCorriente = txt_Ncuenta.Text;
                }

                // Número de teléfono
                string telefono = txt_Telefono.Text;

                if (string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("El campo Número de teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (telefono.Length != 9 || telefono[4] != '-' || !telefono.Replace("-", "").All(char.IsDigit))
                {
                    MessageBox.Show("El teléfono debe tener el formato XXXX-XXXX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsTelefonoUnico(telefono))  // Llamada al método para verificar si el teléfono es único
                {
                    MessageBox.Show("Este número de teléfono ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Telefono = telefono;
                }


                // Correo
                string correo = txtCorreo.Text.Trim();
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("El campo Correo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Regex.IsMatch(correo, patronCorreo))
                {
                    MessageBox.Show("Ingrese un correo válido en formato ejemplo@dominio.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsCorreoUnico(correo))
                {
                    MessageBox.Show("Este correo ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Si pasa todas las validaciones
                    contadorValidaciones++;
                    empleado.Correo = correo;
                }

               


                // Contraseña
                string contrasena = txtContrasena.Text.Trim();
                string patronContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,16}$";
                if (Regex.IsMatch(contrasena, patronContrasena))
                {
                    contadorValidaciones++;
                    empleado.Contrasena = contrasena;
                }
                else if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("La contraseña debe tener al menos:\n- Una letra mayúscula\n- Una letra minúscula\n- Un número\n- Un carácter especial\n- Entre 8 y 16 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificación final
                if (contadorValidaciones == 8)
                {
                    empleado.Estado = "Activo";
                    empleado.AgregarEmpleado();
                    List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
                    dgvEmpleados.DataSource = listaEmpleados;
                }

            }
            catch (Exception ex)
            {
                // Verifica si el error es causado por una violación de clave única
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el empleado. Intente nuevamente.", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["idempleado"].Value);

                empleado.Dui = this.txt_DUI.Text;
                empleado.Nombre = this.txt_Nombre.Text;
                empleado.Apellidos = this.txt_Apellidos.Text;
                empleado.Direccion = this.txt_Direccion.Text;
                empleado.Telefono = this.txt_Telefono.Text;
                empleado.CuentaCorriente = this.txt_Ncuenta.Text;
                empleado.Estado = "Activo";
                empleado.Correo = this.txtCorreo.Text;
                empleado.Contrasena = this.txtContrasena.Text;


                // Contador de validaciones exitosas
                int contadorValidaciones = 0;


                // DUI:
                string dui = txt_DUI.Text;
                if (string.IsNullOrWhiteSpace(txt_DUI.Text))
                {
                    MessageBox.Show("El campo de DUI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dui.Length != 10 || dui[8] != '-' || !dui.Replace("-", "").All(char.IsDigit))
                {
                    MessageBox.Show("El DUI debe tener el formato NNNNNNNNN-N.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsDUIUnico(dui, idEmpleado)) // Llamada al método
                {
                    MessageBox.Show("Este DUI ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Dui = dui;
                }

                // Nombre
                txt_Nombre.Text = txt_Nombre.Text.TrimEnd();
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Nombre.Text.Length < 2)
                {
                    MessageBox.Show("El campo Nombre debe contener al menos dos caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txt_Nombre.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúÑñ]+)?$"))
                {
                    MessageBox.Show("El campo Nombre solo puede contener letras, no números ni caracteres especiales.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Nombre = txt_Nombre.Text;
                }


                // Apellidos
                txt_Apellidos.Text = txt_Apellidos.Text.TrimEnd();
                if (string.IsNullOrWhiteSpace(txt_Apellidos.Text))
                {
                    MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Apellidos.Text.Length < 2)
                {
                    MessageBox.Show("El campo Apellido debe contener al menos dos caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txt_Apellidos.Text, @"^[A-Za-zÁÉÍÓÚáéíóúÑñ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúÑñ]+)?$"))
                {
                    MessageBox.Show("El campo Apellido solo puede contener letras, no números ni caracteres especiales.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Apellidos = txt_Apellidos.Text;
                }



                // Dirección
                if (string.IsNullOrWhiteSpace(txt_Direccion.Text) || txt_Direccion.Text.Length < 2 || !txt_Direccion.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("La Dirección debe contener al menos una letra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
                {
                    MessageBox.Show("El campo de Dirección no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Direccion = txt_Direccion.Text;
                }

                // Número de cuenta
                if (string.IsNullOrWhiteSpace(txt_Ncuenta.Text))
                {
                    MessageBox.Show("El campo Cuenta Corriente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txt_Ncuenta.Text.Length != 15)
                {
                    MessageBox.Show("La Cuenta Corriente debe tener exactamente 12 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsCuentaUnica(txt_Ncuenta.Text, idEmpleado))
                {
                    MessageBox.Show("Este número de cuenta ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.CuentaCorriente = txt_Ncuenta.Text;
                }

                // Número de teléfono
                string telefono = txt_Telefono.Text;

                if (string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("El campo Número de teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (telefono.Length != 9 || telefono[4] != '-' || !telefono.Replace("-", "").All(char.IsDigit))
                {
                    MessageBox.Show("El teléfono debe tener el formato XXXX-XXXX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsTelefonoUnico(telefono, idEmpleado))  // Llamada al método para verificar si el teléfono es único con idEmpleado
                {
                    MessageBox.Show("Este número de teléfono ya está registrado. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Telefono = telefono;
                }


                // Correo
                string correo = txtCorreo.Text.Trim();
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("El campo Correo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Regex.IsMatch(correo, patronCorreo))
                {
                    MessageBox.Show("Ingrese un correo válido en formato ejemplo@dominio.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!empleado.EsCorreoUnico(correo, idEmpleado))
                {
                    MessageBox.Show("Este correo ya está registrado. Por favor, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    contadorValidaciones++;
                    empleado.Correo = correo;
                }


                // Contraseña
                string contrasena = txtContrasena.Text.Trim();
                string patronContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,16}$";
                if (Regex.IsMatch(contrasena, patronContrasena))
                {
                    contadorValidaciones++;
                    empleado.Contrasena = contrasena;
                }
                else if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("La contraseña debe tener al menos:\n- Una letra mayúscula\n- Una letra minúscula\n- Un número\n- Un carácter especial\n- Entre 8 y 16 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificación final
                if (contadorValidaciones == 8)
                {
                    if (dgvEmpleados.SelectedRows.Count > 0)
                    {
                        empleado.EditarEmpleado(idEmpleado);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un empleado para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
                    dgvEmpleados.DataSource = listaEmpleados;
                }

            }
            catch (Exception ex)
            {
                // Verifica si el error es causado por una violación de clave única
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hubo un error al editar los datos del empleado. Intente nuevamente.", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void agregarEmpleado_Load(object sender, EventArgs e)
        {
            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
            //btn_Guardar.Enabled = false;
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            //btn_Guardar.Enabled = false;
            //btn_Modificar.Enabled = true;

            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvEmpleados.SelectedRows[0];
                txt_DUI.Text = fila.Cells["dui"].Value?.ToString();
                txt_Nombre.Text = fila.Cells["nombre"].Value?.ToString();
                txt_Apellidos.Text = fila.Cells["apellidos"].Value?.ToString();
                txt_Direccion.Text = fila.Cells["direccion"].Value?.ToString();
                txt_Telefono.Text = fila.Cells["telefono"].Value?.ToString();
                txt_Ncuenta.Text = fila.Cells["cuentacorriente"].Value?.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value?.ToString();
                txtContrasena.Text = fila.Cells["contrasena"].Value?.ToString();
            }
        }




        private void btnGenerarContrasena_Click(object sender, EventArgs e)
        {
            char[] letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] letrasMinusculas = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] numeros = "1234567890".ToCharArray();
            char[] caracteresEspeciales = "!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();

            Random random = new Random();

            // Longitud aleatoria entre 8 y 16 caracteres
            int longitud = random.Next(8, 17);

            char[] contrasena = new char[longitud];

            // Asegurarse de incluir al menos un carácter de cada tipo
            contrasena[0] = letrasMayusculas[random.Next(letrasMayusculas.Length)];
            contrasena[1] = letrasMinusculas[random.Next(letrasMinusculas.Length)];
            contrasena[2] = numeros[random.Next(numeros.Length)];
            contrasena[3] = caracteresEspeciales[random.Next(caracteresEspeciales.Length)];

            // Rellenar el resto de la contraseña con caracteres aleatorios
            for (int i = 4; i < longitud; i++)
            {
                int tipoCaracter = random.Next(4);
                switch (tipoCaracter)
                {
                    case 0:
                        contrasena[i] = letrasMayusculas[random.Next(letrasMayusculas.Length)];
                        break;
                    case 1:
                        contrasena[i] = letrasMinusculas[random.Next(letrasMinusculas.Length)];
                        break;
                    case 2:
                        contrasena[i] = numeros[random.Next(numeros.Length)];
                        break;
                    case 3:
                        contrasena[i] = caracteresEspeciales[random.Next(caracteresEspeciales.Length)];
                        break;
                }
            }

            // Convertir el array de caracteres en una cadena
            string contrasenaGenerada = new string(contrasena);
            txtContrasena.Text = contrasenaGenerada; // Asignar al TextBox


        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEmpleados.ClearSelection();

            txt_DUI.Text = "";
            txt_Nombre.Text = "";
            txt_Apellidos.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";
            txt_Ncuenta.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeAdmin frm = new HomeAdmin();
            frm.Show();
            this.Hide();
        }

        private void txt_Ncuenta_TextChanged(object sender, EventArgs e)
        {
            int cursorPos = txt_Ncuenta.SelectionStart; 
            int lengthBefore = txt_Ncuenta.Text.Length;

            if (txt_Ncuenta.Text.Any(c => !char.IsDigit(c) && c != '-'))
            {
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Ncuenta.Text = new string(txt_Ncuenta.Text.Where(char.IsDigit).ToArray()); 
                txt_Ncuenta.SelectionStart = txt_Ncuenta.Text.Length; 
                return;
            }

            string numeroSinGuiones = new string(txt_Ncuenta.Text.Where(char.IsDigit).ToArray());

            if (numeroSinGuiones.Length > 12)
            {
                numeroSinGuiones = numeroSinGuiones.Substring(0, 12);
            }

            // Aplicar formato con guiones
            string formato = "";
            if (numeroSinGuiones.Length > 0)
                formato += numeroSinGuiones.Substring(0, Math.Min(2, numeroSinGuiones.Length));
            if (numeroSinGuiones.Length > 2)
                formato += "-" + numeroSinGuiones.Substring(2, Math.Min(2, numeroSinGuiones.Length - 2));
            if (numeroSinGuiones.Length > 4)
                formato += "-" + numeroSinGuiones.Substring(4, Math.Min(7, numeroSinGuiones.Length - 4));
            if (numeroSinGuiones.Length > 11)
                formato += "-" + numeroSinGuiones.Substring(11, 1);

            if (txt_Ncuenta.Text != formato)
            {
                txt_Ncuenta.Text = formato;
                txt_Ncuenta.SelectionStart = formato.Length; 
            }
        }



        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            string numeroSinGuiones = txt_Telefono.Text.Replace("-", "");

            // Permitir solo números
            if (!long.TryParse(numeroSinGuiones, out _) && numeroSinGuiones.Length > 0)
            {
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Telefono.Text = empleado.FormatearTelefono(numeroSinGuiones[..^1]); // Eliminar el último carácter
                txt_Telefono.SelectionStart = txt_Telefono.Text.Length;
                return;
            }

            // Formatear con guión (XXXX-XXXX)
            txt_Telefono.Text = empleado.FormatearTelefono(numeroSinGuiones);
            txt_Telefono.SelectionStart = txt_Telefono.Text.Length;
        }

        private void txt_DUI_TextChanged(object sender, EventArgs e)
        {
            string duiSinGuiones = txt_DUI.Text.Replace("-", ""); // Eliminar guion

            if (!long.TryParse(duiSinGuiones, out _) && duiSinGuiones.Length > 0)
            {
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DUI.Text = empleado.FormatearDUI(duiSinGuiones[..^1]); // Eliminar el último carácter
                txt_DUI.SelectionStart = txt_DUI.Text.Length;
                return;
            }

            // Limitar a 8 dígitos y formatear con guión (NNNNNNNN-N)
            txt_DUI.Text = empleado.FormatearDUI(duiSinGuiones);
            txt_DUI.SelectionStart = txt_DUI.Text.Length;
        }


       

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                var cellValue = dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idEmpleado))
                {
                    empleado.CrearReporte(idEmpleado);
                }
                else
                {
                    MessageBox.Show("El ID del empleado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para generar el reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
