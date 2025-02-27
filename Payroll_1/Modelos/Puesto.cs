using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Puesto
    {
        Conexion conexion = new Conexion();
        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public int IdCategoria { get; set; }

        //CONSTRUCTORES
        public Puesto(int idPuesto,string nombrepuesto)
        {
            this.IdPuesto = idPuesto;
            this.NombrePuesto = nombrepuesto;
        }
        public Puesto(int idPuesto, string nombrepuesto, int idCategoria)
        {
            this.IdPuesto= idPuesto;
            this.NombrePuesto= nombrepuesto;
            this.IdCategoria = idCategoria;
        }

        public Puesto() { }

        // MÉTODO PARA OBTENER TODOS LOS PUESTOS
        public List<Puesto> MostrarPuestos()
        {
            List<Puesto> listaPuestos = new List<Puesto>();

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "SELECT * FROM Puesto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Puesto puesto = new Puesto
                                {
                                    IdPuesto = Convert.ToInt32(reader["id_puesto"]),
                                    NombrePuesto = reader["nombre_puesto"].ToString(),
                                    IdCategoria = Convert.ToInt32(reader["id_categoria"])
                                };
                                listaPuestos.Add(puesto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaPuestos;
        }

        //agregar
        public bool AgregarPuesto()
        {
            if (string.IsNullOrWhiteSpace(NombrePuesto) || IdCategoria <= 0)
            {
                MessageBox.Show("El nombre del puesto y la categoría son obligatorios.");
                return false;
            }

            try
            {
                Conexion con = new Conexion();
                string query = "INSERT INTO Puesto (nombre_puesto, id_categoria) VALUES (@nombrePuesto, @idCategoria)";

                using (SqlConnection conexion = con.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombrePuesto", NombrePuesto);
                        cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);

                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        conexion.Close();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el puesto. Verifique los datos.");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error SQL: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar puesto: " + ex.Message);
                return false;
            }
        }

        //editar
        public bool EditarPuesto()
        {
            if (IdPuesto <= 0 || string.IsNullOrWhiteSpace(NombrePuesto) || IdCategoria <= 0)
            {
                MessageBox.Show("El puesto, nombre y categoría son obligatorios.");
                return false;
            }

            try
            {
                Conexion con = new Conexion();
                string query = "UPDATE Puesto SET nombre_puesto = @nombrePuesto, id_categoria = @idCategoria WHERE id_puesto = @idPuesto";

                using (SqlConnection conexion = con.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombrePuesto", NombrePuesto);
                        cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
                        cmd.Parameters.AddWithValue("@idPuesto", IdPuesto);

                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        conexion.Close();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el puesto. Verifique los datos.");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error SQL: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar puesto: " + ex.Message);
                return false;
            }
        }

    }
}

