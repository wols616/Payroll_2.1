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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Payroll_1.Formularios
{
    public partial class agregarNuevasDeducciones : Form
    {
        public agregarNuevasDeducciones()
        {
            InitializeComponent();
        }

        private void cargarTablaDeducciones()
        {
            dgvDeducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Deduccion> deducciones = Deduccion.ObtenerDeducciones();
            dgvDeducciones.DataSource = deducciones;
            dgvDeducciones.Columns["IdDeduccion"].Visible = false;
            dgvDeducciones.Columns["Monto"].Visible = false;
        }
        private void agregarDeducciones_Load(object sender, EventArgs e)
        {
            cargarTablaDeducciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreDeduccion = this.txtNombre.Text;
            decimal porcentaje = Decimal.Parse(this.txtPorcentajee.Text);
            Deduccion deduccion = new Deduccion(nombreDeduccion, porcentaje);
            deduccion.AgregarDeduccion();
            cargarTablaDeducciones();
        }

        private void dgvDeducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    // Obtener los valores de la fila seleccionada
            //    DataGridViewRow row = dgvDeducciones.Rows[e.RowIndex];
            //    txtNombre.Text = row.Cells["NombreDeduccion"].Value.ToString();
            //    txtPorcentaje.Text = row.Cells["Porcentaje"].Value.ToString();
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDeducciones.CurrentRow != null)
            {
                int idDeduccion = Convert.ToInt32(dgvDeducciones.CurrentRow.Cells["IdDeduccion"].Value);
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta deducción?",
                                             "Confirmación de eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Deduccion.EliminarDeduccion(idDeduccion);
                }
                cargarTablaDeducciones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idDeduccion = Convert.ToInt32(dgvDeducciones.CurrentRow.Cells["IdDeduccion"].Value);
            string nombreDeduccion = this.txtNombre.Text;
            decimal porcentaje = Decimal.Parse(this.txtPorcentajee.Text);

            Deduccion deduccion = new Deduccion(idDeduccion, nombreDeduccion, porcentaje);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea actualizar esta deducción?",
                                             "Confirmación de actualización",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                deduccion.ActualizarDeduccion();
            }
            cargarTablaDeducciones();
        }

        private void dgvDeducciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeducciones.CurrentRow != null)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvDeducciones.CurrentRow;
                txtNombre.Text = row.Cells["NombreDeduccion"].Value.ToString();
                txtPorcentajee.Text = row.Cells["Porcentaje"].Value.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPorcentajee_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarNuevasDeducciones_MouseClick(object sender, MouseEventArgs e)
        {
            dgvDeducciones.ClearSelection();
            this.txtNombre.Text = "";
            this.txtPorcentajee.Text = "";
        }

        private void txtPorcentajee_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y el signo de porcentaje
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evitar más de un punto decimal
            if (e.KeyChar == '.' && txtPorcentajee.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Validar que el valor no sea mayor a 100
            if (!string.IsNullOrEmpty(txtPorcentajee.Text) && txtPorcentajee.Text != ".")
            {
                // Intentar convertir a decimal para evitar errores
                if (decimal.TryParse(txtPorcentajee.Text + e.KeyChar, out decimal valor))
                {
                    if (valor >= 100)
                    {
                        MessageBox.Show("No se permite un valor mayor o igual a 100%.");
                        e.Handled = true; // Evita que el número sea ingresado
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
    }
}
