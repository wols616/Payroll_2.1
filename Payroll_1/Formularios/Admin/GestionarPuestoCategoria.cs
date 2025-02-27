using System;
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
    public partial class GestionarPuestoCategoria : Form
    {
        public GestionarPuestoCategoria()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AgregarCategoria frm = new AgregarCategoria();
            frm.Show();
            this.Dispose();
        }

        private void btnGestionarPuestos_Click(object sender, EventArgs e)
        {
            AgregarPuestos frm = new AgregarPuestos();
            frm.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeAdmin frm = new HomeAdmin();
            frm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VerPuestos frm = new VerPuestos();
            //frm.Show();
            //this.Dispose();
        }
    }
}
