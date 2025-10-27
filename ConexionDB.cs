using System.Data.SqlClient;

namespace CalculadoraPrj1
{
    internal class ConexionBD
    {
        private static string cadenaConexion =
        "Server=localhost;Database=CalculadoraDB_;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static void GuardarOperacion(string operacion, string resultado)
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    string query = @"INSERT INTO Calculos (Operacion, Resultado) 
                           VALUES (@operacion, @resultado)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@operacion", operacion);
                        comando.Parameters.AddWithValue("@resultado", resultado);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Solo mostrar error si es algo grave, no por duplicados
                MessageBox.Show($"Error al guardar en BD: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}