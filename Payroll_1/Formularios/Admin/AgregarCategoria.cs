using Microsoft.IdentityModel.Tokens;
using Payroll_1.Formularios.Admin;
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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void cargarTablaDCategoria()
        {
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Categoria> categoria = Categoria.ObtenerCategorias();
            dgvCategoria.DataSource = categoria;
            dgvCategoria.Columns["IdCategoria"].Visible = false;
        }


        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            cargarTablaDCategoria();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string nombreCategoria = this.TxtNombreCat.Text;
            string sueldobase = this.TxtSueldoBase.Text;

            if (string.IsNullOrEmpty(nombreCategoria) || string.IsNullOrEmpty(sueldobase))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(sueldobase, out decimal sueldoBase))
            {
                MessageBox.Show("Ingrese un sueldo base válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sueldoBase < 0)
            {
                MessageBox.Show("No se aceptan números negativos");
                return;
            }
            Categoria categoria = new Categoria(nombreCategoria, sueldoBase);

            if (categoria.AgregarCategoria())
            {
                MessageBox.Show("Categoría agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarTablaDCategoria(); // Actualizar la tabla
            }
            else
            {
                MessageBox.Show("La categoría con el mismo nombre y sueldo base ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (dgvCategoria.CurrentRow != null)
        //    {
        //        int idCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells["IdCategoria"].Value);
        //        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoria?",
        //                                     "Confirmación de eliminación",
        //                                     MessageBoxButtons.YesNo,
        //                                     MessageBoxIcon.Information);
        //        if (resultado == DialogResult.Yes)
        //        {
        //            Categoria.EliminarCategoria(idCategoria);
        //        }
        //        cargarTablaDCategoria();
        //    }

        //}

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategoria.Rows[e.RowIndex];
                TxtNombreCat.Text = row.Cells["NombreCategoria"].Value?.ToString() ?? "";
                TxtSueldoBase.Text = row.Cells["SueldoBase"].Value?.ToString() ?? "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count != 0)
            {
                try
                {
                    int idCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells["IdCategoria"].Value);
                    string nombreCategoria = TxtNombreCat.Text;
                    decimal sueldobase;

                    if (!decimal.TryParse(TxtSueldoBase.Text, out sueldobase) || sueldobase < 0)
                    {
                        MessageBox.Show("Ingrese un sueldo base válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(nombreCategoria))
                    {
                        MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Categoria categoria = new Categoria(idCategoria, nombreCategoria, sueldobase);

                    // Confirmación antes de actualizar
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea actualizar esta categoría?",
                                                             "Confirmación de actualización",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        categoria.ActualizarCategoria();
                        cargarTablaDCategoria();
                        MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                DataGridViewRow row = dgvCategoria.CurrentRow;
                TxtNombreCat.Text = row.Cells["NombreCategoria"].Value.ToString();
                TxtSueldoBase.Text = row.Cells["SueldoBase"].Value.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void AgregarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            dgvCategoria.ClearSelection();
            this.TxtNombreCat.Text = "";
            this.TxtSueldoBase.Text = "";
        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            AgregarPuestos frm = new AgregarPuestos();
            frm.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionarPuestoCategoria frm = new GestionarPuestoCategoria();
            frm.Show();
            this.Dispose();
        }
    }
}
