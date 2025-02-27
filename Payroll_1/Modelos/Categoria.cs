﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Payroll_1.Modelos
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public decimal SueldoBase { get; set; }

        //CONSTRUCTORES
        public Categoria(string nombreCategoria, decimal sueldobase)
        {
            this.NombreCategoria = nombreCategoria;
            this.SueldoBase = sueldobase;
        }
        public Categoria(int idCategoria, string nombreCategoria, decimal sueldobase)
        {
            this.IdCategoria = idCategoria;
            this.NombreCategoria = nombreCategoria;
            this.SueldoBase = sueldobase;
        }

        public Categoria() { }

        //METODOS CRUD CATEGORIA
        //SELECT CATEGORIA
        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categoriaList = new List<Categoria>();

            // Consulta SQL para obtener todas las deducciones
            string query = "SELECT * FROM Categoria";

            Conexion conexion = new Conexion();

            using (SqlConnection connection = conexion.GetConnection())
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Leer los datos de la base de datos
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Procesar cada fila y agregarla a la lista
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria
                                {
                                    IdCategoria = reader.GetInt32(0),
                                    NombreCategoria = reader.GetString(1),
                                    SueldoBase = reader.GetDecimal(2)
                                };

                                // Agregar el objeto Deduccion a la lista
                                categoriaList.Add(categoria);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las categorias: " + ex.Message);
                }
            }

            // Retornar la lista de deducciones
            return categoriaList;
        }

        //INSERTAR CATEGORIA
        public bool AgregarCategoria()
        {
            bool exito = false;

            // Consulta SQL para insertar una nueva deducción
            string query = "INSERT INTO Categoria (nombre_categoria, sueldo_base) VALUES (@NombreCategoria, @SueldoBase)";

            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.GetConnection())
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando SQL y agregar los parámetros
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCategoria", NombreCategoria);
                        command.Parameters.AddWithValue("@SueldoBase", SueldoBase);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Si se afectaron filas, la inserción fue exitosa
                        if (rowsAffected > 0)
                        {
                            exito = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar la categoria: " + ex.Message);
                }
            }

            return exito;
        }

        // MÉTODO PARA OBTENER LA CATEGORIA DE UN PUESTO
        public Categoria ObtenerCategoria(int idCategoria)
        {
            Categoria categoria = null;
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "SELECT id_categoria, nombre_categoria, sueldo_base FROM Categoria WHERE id_categoria = @id_categoria";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = idCategoria;
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoria = new Categoria
                                {
                                    IdCategoria = reader.GetInt32(0),
                                    NombreCategoria = reader.GetString(1),
                                    SueldoBase = reader.GetDecimal(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return categoria;
        }

        //////ELIMINAR CATEGORIA
        ////public static bool EliminarCategoria(int idCat)
        ////{
        ////    bool exito = false;

        ////    // Consulta SQL para eliminar una deducción por su Id
        ////    string query = "DELETE FROM Categoria WHERE id_categoria = @IdCategoria";

        ////    Conexion conexion = new Conexion();
        ////    using (SqlConnection connection = conexion.GetConnection())
        ////    {
        ////        try
        ////        {
        ////            // Abrir la conexión
        ////            connection.Open();

        ////            // Crear el comando SQL y agregar el parámetro
        ////            using (SqlCommand command = new SqlCommand(query, connection))
        ////            {
        ////                command.Parameters.AddWithValue("@IdCategoria", idCat);

        ////                // Ejecutar la consulta
        ////                int rowsAffected = command.ExecuteNonQuery();

        ////                // Si se afectaron filas, la eliminación fue exitosa
        ////                if (rowsAffected > 0)
        ////                {
        ////                    exito = true;
        ////                }
        ////            }
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            Console.WriteLine("Error al eliminar la categoria: " + ex.Message);
        ////        }
        ////    }

        ////    return exito;
        ////}

        // ACTUALIZAR CATEGORIA
        public bool ActualizarCategoria()
        {
            bool exito = false;

            // Consulta SQL para actualizar una deducción
            string query = "UPDATE Categoria SET nombre_categoria = @NuevoNombre, sueldo_base = @NuevoSueldo WHERE id_categoria = @IdCategoria";

            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.GetConnection())
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando SQL y agregar los parámetros
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NuevoNombre", NombreCategoria);
                        command.Parameters.AddWithValue("@NuevoSueldo", SueldoBase);
                        command.Parameters.AddWithValue("@IdCategoria", IdCategoria);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Si se afectaron filas, la actualización fue exitosa
                        if (rowsAffected > 0)
                        {
                            exito = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar la categoria: " + ex.Message);
                }
            }

            return exito;
        }

        //extras
        public bool ExisteCategoria()
        {
            string query = "SELECT COUNT(*) FROM Categoria WHERE nombre_categoria = @NombreCategoria AND sueldo_base = @SueldoBase";

            using (SqlConnection conexion = new SqlConnection(""))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreCategoria", NombreCategoria);
                    cmd.Parameters.AddWithValue("@SueldoBase", SueldoBase);
                    conexion.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
