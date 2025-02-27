using Payroll_1.Modelos;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios.Admin
{
    public partial class AgregarPuestos : Form
    {
        public AgregarPuestos()
        {
            InitializeComponent();
        }
        private void cargarTablaDPuesto()
        {
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    string query = @"
                        SELECT p.id_puesto, p.nombre_puesto, c.id_categoria, c.nombre_categoria, c.sueldo_base
                           FROM Puesto p
                        INNER JOIN Categoria c ON p.id_categoria = c.id_categoria";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dgvPuestos.DataSource = dt;

                        // Ocultar ID si no es necesario
                        dgvPuestos.Columns["id_puesto"].Visible = false;
                        dgvPuestos.Columns["id_categoria"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarComboCategorias()
        {
            try
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    string query = "SELECT id_categoria, nombre_categoria FROM Categoria";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cbCategoria.DataSource = dt;
                        cbCategoria.DisplayMember = "nombre_categoria";
                        cbCategoria.ValueMember = "id_categoria";
                        cbCategoria.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionarPuestoCategoria frm = new GestionarPuestoCategoria();
            frm.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombrePuesto.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del puesto.");
                return;
            }
            if (!int.TryParse(cbCategoria.SelectedValue.ToString(), out int idCategoria))
            {
                MessageBox.Show("Error al obtener la categoría seleccionada.");
                return;
            }

            Puesto nuevoPuesto = new Puesto
            {
                NombrePuesto = txtNombrePuesto.Text,
                IdCategoria = idCategoria
            };
            bool exito = nuevoPuesto.AgregarPuesto();
            if (exito)
            {
                MessageBox.Show("Puesto agregado correctamente.");
                txtNombrePuesto.Text = "";
                dgvPuestos.ClearSelection();
                cbCategoria.SelectedIndex = -1;
            }
            cargarTablaDPuesto();
        }

        private void AgregarPuestos_Load(object sender, EventArgs e)
        {
            cargarTablaDPuesto();
            cargarComboCategorias();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedValue != null)
            {
                if (int.TryParse(cbCategoria.SelectedValue.ToString(), out int idCategoria))
                {
                    using (SqlConnection con = new Conexion().GetConnection())
                    {
                        string query = "SELECT sueldo_base FROM Categoria WHERE id_categoria = @idCategoria";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                            con.Open();
                            object result = cmd.ExecuteScalar();
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPuestos.Rows[e.RowIndex];

                txtNombrePuesto.Text = row.Cells["nombre_puesto"].Value?.ToString() ?? "";
                cbCategoria.Text = row.Cells["nombre_categoria"].Value?.ToString() ?? "";
                txtSueldoBase.Text = row.Cells["sueldo_base"].Value?.ToString() ?? "";
            }
        }

        private void dvgPuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow != null)
            {
                DataGridViewRow row = dgvPuestos.CurrentRow;
                txtNombrePuesto.Text = row.Cells["nombre_puesto"].Value?.ToString();
                cbCategoria.Text = row.Cells["nombre_categoria"].Value?.ToString();
                txtSueldoBase.Text = row.Cells["sueldo_base"].Value?.ToString();
            }
        }

        private void AgregarPuestos_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombrePuesto.Text = "";
            txtSueldoBase.Clear();
            cbCategoria.SelectedIndex = -1;

            // Desactivar selección en el DataGridView
            dgvPuestos.ClearSelection();
            dgvPuestos.CurrentCell = null;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombrePuesto.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del puesto.");
                return;
            }

            if (dgvPuestos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un puesto para editar.");
                return;
            }

            int idPuesto = Convert.ToInt32(dgvPuestos.CurrentRow.Cells["id_puesto"].Value);
            int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);

            Puesto puestoEditado = new Puesto
            {
                IdPuesto = idPuesto,
                NombrePuesto = txtNombrePuesto.Text,
                IdCategoria = idCategoria
            };

            bool exito = puestoEditado.EditarPuesto();

            if (exito)
            {
                MessageBox.Show("Puesto editado correctamente.");
                cargarTablaDPuesto();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSueldoBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
