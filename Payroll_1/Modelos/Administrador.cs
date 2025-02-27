using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Payroll_1.Formularios;

namespace Payroll_1.Modelos
{
    internal class Administrador
    {
        public int IdAdministrador { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Administrador() { }

        Conexion conexion = new Conexion();


        public int LoginAdministrador(string correo, string contrasena)
        {
            int idAdministrador = -1;

            using (SqlConnection con = conexion.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT id_administrador FROM Administrador WHERE correo = @correo AND contrasena = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            idAdministrador = Convert.ToInt32(result);
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idAdministrador;
        }

    }
}
