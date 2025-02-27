using Payroll_1.Formularios.Admin;
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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void btnGestionarEmpleados_Click(object sender, EventArgs e)
        {
            GestionarEmpleados frm = new GestionarEmpleados();
            frm.Show();
            this.Hide();
        }

        private void btnGestionarPuestoCategoria_Click(object sender, EventArgs e)
        {
            GestionarPuestoCategoria frm = new GestionarPuestoCategoria();
            frm.Show();
            this.Hide();
        }

        private void btnGestionarContratos_Click(object sender, EventArgs e)
        {
            gestionarContratos frm = new gestionarContratos();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Función para deslogearse
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
