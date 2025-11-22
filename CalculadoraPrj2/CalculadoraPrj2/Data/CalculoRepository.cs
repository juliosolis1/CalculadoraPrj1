using CalculadoraPrj2.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CalculadoraPrj2.Data
{
    // Clase responsable de hablar con SQL Server
    public class CalculosRepository
    {
        // Lee la cadena de conexión del Web.config
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["CalculadoraDB"].ConnectionString;

        // Método interno genérico para ejecutar consultas
        private List<Calculo> EjecutarConsulta(string whereClause = "")
        {
            var lista = new List<Calculo>();

            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                cn.Open();

                string sql = "SELECT ID, Operacion, Resultado FROM Calculos " + whereClause;

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        var calc = new Calculo
                        {
                            ID = rd.GetInt32(0),
                            Operacion = rd.GetString(1),
                            Resultado = rd.GetString(2)
                        };
                        lista.Add(calc);
                    }
                }
            }

            return lista;
        }

        // ===== Métodos públicos que usará el controlador =====

        // 1. Todos los cálculos
        public List<Calculo> GetTodos()
            => EjecutarConsulta();

        // 2. Todas las sumas: "n + m"
        public List<Calculo> GetSumas()
            => EjecutarConsulta("WHERE Operacion LIKE '% + %'");

        // 3. Todas las restas: "n - m"
        public List<Calculo> GetRestas()
            => EjecutarConsulta("WHERE Operacion LIKE '% - %'");

        // 4. Todas las multiplicaciones: "n * m"
        public List<Calculo> GetMultiplicaciones()
            => EjecutarConsulta("WHERE Operacion LIKE '% * %'");

        // 5. Todas las divisiones: "n / m"
        public List<Calculo> GetDivisiones()
            => EjecutarConsulta("WHERE Operacion LIKE '% / %'");

        // 6. Todas las potencias cuadradas: "n^2"
        public List<Calculo> GetCuadrados()
            => EjecutarConsulta("WHERE Operacion LIKE '%^2'");

        // 7. Todas las raíces cuadradas: "sqrt(n)"
        public List<Calculo> GetRaices()
            => EjecutarConsulta("WHERE Operacion LIKE 'sqrt(%'");
    }
}
