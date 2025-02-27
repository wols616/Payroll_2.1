using Payroll_1.Formularios;

namespace Payroll_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            agregarNuevasDeducciones frm = new agregarNuevasDeducciones();
            frm.Show();
            this.Hide();
        }

        private void btnAsignarDeducciones_Click(object sender, EventArgs e)
        {
            generarNomina frm = new generarNomina();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarEmpleados frm = new GestionarEmpleados();
            frm.Show();
            this.Hide();
        }


        private void btn_contrats_Click(object sender, EventArgs e)
        {
            gestionarContratos frm = new gestionarContratos();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCategoria frm = new AgregarCategoria();
            frm.Show();
            this.Hide();
        }
    }
}
