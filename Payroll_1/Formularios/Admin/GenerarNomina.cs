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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Payroll_1.Formularios
{
    public partial class generarNomina : Form
    {
        decimal sueldoB = 400;
        decimal totalDeducciones = 0;
        decimal sueldoNetro = 0;
        Empleados empleado = new Empleados();
        public generarNomina()
        {
            InitializeComponent();
        }

        private void cargarTablaEmpleados()
        {
            //Empleado empleado1 = new Empleado(1, "01234567-8", "Carlos", "Ramírez", "7777-1234", "San Salvador, El Salvador", "1234567890123456");
            //Empleado empleado2 = new Empleado(2, "09876543-2", "Ana", "López", "7777-5678", "Santa Tecla, El Salvador", "6543210987654321");
            //Empleado empleado3 = new Empleado(3, "12345678-9", "Luis", "González", "7777-8765", "Soyapango, El Salvador", "0987654321123456");
            //List<Empleado> empleados = new List<Empleado>();
            //empleados.Add(empleado1);
            //empleados.Add(empleado2);
            //empleados.Add(empleado3);


            //-----------------------------------------------------------------------------------------------------------------------------------
            dgvEmpleados.DataSource = empleado.MostrarEmpleados();
        }

        private void cargarComboBoxDeducciones()
        {
            List<Deduccion> deducciones = Deduccion.ObtenerDeducciones();
            cbxDeducciones.DataSource = deducciones;
            cbxDeducciones.DisplayMember = "NombreDeduccion";
            cbxDeducciones.ValueMember = "IdDeduccion";
        }

        private void calcularTotales(List<Deduccion> dp)
        {
            totalDeducciones = 0;
            txtSueldoBase.Text = "Sueldo Base: " + this.sueldoB;

            foreach (var deduccion in dp)
            {
                deduccion.Monto = (deduccion.Porcentaje / 100) * sueldoB;
            }

            foreach (var deduccion in dp)
            {
                totalDeducciones += deduccion.Monto;
            }
            sueldoNetro = sueldoB - totalDeducciones;
            txtTotalDeducciones.Text = "Total: " + Math.Round(totalDeducciones, 2);
            txtSalarioNeto.Text = "Sueldo Neto: " + Math.Round((sueldoNetro), 2);
        }

        private decimal obtenerTotalDeducciones(List<Deduccion> dp)
        {
            totalDeducciones = 0;
            //txtSueldoBase.Text = "Sueldo Base: " + this.sueldoB;

            foreach (var deduccion in dp)
            {
                deduccion.Monto = (deduccion.Porcentaje / 100) * sueldoB;
            }

            foreach (var deduccion in dp)
            {
                totalDeducciones += deduccion.Monto;
            }
            return totalDeducciones;
        }

        private void cargarTablaDeducciones(int idEmpleado)
        {

            List<Deduccion> deduccionesPersonales = Deduccion_Personal.ObtenerDeduccionesPersonales(idEmpleado);

            dgvDeducciones.DataSource = null;
            dgvDeducciones.DataSource = deduccionesPersonales;
            dgvDeducciones.Columns["IdDeduccion"].Visible = false;
            dgvDeducciones.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvDeducciones.Columns["Porcentaje"].DefaultCellStyle.Format = "0.##'%'";

            calcularTotales(deduccionesPersonales);

            desactivarSeleccionTDeduccion();

        }
        private void desactivarSeleccionTDeduccion()
        {
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvDeducciones.ClearSelection();
            dgvDeducciones.Enabled = false;
        }
        private void cambiarBoton()
        {
            string nombreColumna = "IdDeduccion";
            Deduccion deduccion = (Deduccion)cbxDeducciones.SelectedItem;

            foreach (DataGridViewRow fila in dgvDeducciones.Rows)
            {
                if (fila.Cells[nombreColumna].Value != null)
                {
                    int idDeduccion = Int32.Parse(fila.Cells[nombreColumna].Value.ToString());

                    if (idDeduccion == deduccion.IdDeduccion)
                    {
                        this.btnAsignar.Text = "Exento";
                        return;
                    }
                    this.btnAsignar.Text = "Asignar";
                }
            }
        }
        private void asignarDeduccionesEmpleado_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            cargarTablaEmpleados();
            cargarComboBoxDeducciones();
            desactivarSeleccionTDeduccion();
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvEmpleados.CurrentRow;

                cargarTablaDeducciones(Int32.Parse(row.Cells["IdEmpleado"].Value.ToString()));
            }
        }

        private void cbxDeducciones_SelectedValueChanged(object sender, EventArgs e)
        {
            cambiarBoton();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            Deduccion deduccion = (Deduccion)cbxDeducciones.SelectedItem;
            if (dgvEmpleados.CurrentRow != null)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvEmpleados.CurrentRow;

                int idEmpleado = Convert.ToInt32(row.Cells["IdEmpleado"].Value);

                List<Deduccion> deduccionsPersonales = Deduccion_Personal.ObtenerDeduccionesPersonales(Int32.Parse(row.Cells["IdEmpleado"].Value.ToString()));

                decimal totalDeducciones = obtenerTotalDeducciones(deduccionsPersonales) + ((deduccion.Porcentaje / 100) * sueldoB);

                if (totalDeducciones >= sueldoB)
                {
                    MessageBox.Show("No puedes asignar esta deducción porque supera o iguala el sueldo base.");
                    return;
                }

                if (this.btnAsignar.Text == "Asignar")
                {
                    Deduccion_Personal deduccion_Personal = new Deduccion_Personal(deduccion.IdDeduccion, idEmpleado);
                    deduccion_Personal.AgregarDeduccionPersonal();
                }
                else if (this.btnAsignar.Text == "Exento")
                {
                    Deduccion_Personal.EliminarDeduccionPersonal(deduccion.IdDeduccion, idEmpleado);
                }

                cargarTablaDeducciones(idEmpleado);
                cambiarBoton();

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            cambiarBoton();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
    }
}
