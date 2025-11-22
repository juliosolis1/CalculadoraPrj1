using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraPrj2.Models
    {
        // Representa una fila de la tabla Calculos de la BD
        public class Calculo
        {
            public int ID { get; set; }
            public string Operacion { get; set; }   // texto de operación a realizar
            public string Resultado { get; set; }   // texto con el resultado
        }
    }
