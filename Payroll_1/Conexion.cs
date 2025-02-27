﻿using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Payroll_1
{
    internal class Conexion
    {
        // Cadena de conexión definida dentro de la clase
        private readonly string connectionString = "Server=LOCALHOST;Database=payroll_1;User Id=wil;Password=123456;Encrypt=False;";

        // Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void OpenConnection(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
