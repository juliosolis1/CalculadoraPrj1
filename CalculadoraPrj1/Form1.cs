using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculadoraPrj1
{
    public partial class Calculadora : Form
    {
        // ===== Estado interno =====
        private decimal acumulado = 0m;      // Guarda resultados intermedios
        private string operacion = null;     // "+", "-", "*", "/"
        private bool iniciarNuevaEntrada = true; // Para iniciar nueva entrada tras operación/igual
        private bool huboError = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            // Asegura que el display inicie en 0
            if (string.IsNullOrWhiteSpace(calculo.Text))
                calculo.Text = "0";
        }

        // === Utilitarios base ===

        private bool TryLeer(out decimal valor)
        {
            // Forzamos punto "." como separador decimal
            return decimal.TryParse(calculo.Text, NumberStyles.Float,
                                    CultureInfo.InvariantCulture, out valor);
        }

        private void Mostrar(decimal v)
        {
            calculo.Text = v.ToString("G29", CultureInfo.InvariantCulture);
        }

        private void AppendDigito(string d)
        {
            if (huboError) return;

            if (iniciarNuevaEntrada || calculo.Text == "0")
            {
                calculo.Text = d;
                iniciarNuevaEntrada = false;
            }
            else
            {
                calculo.Text += d;
            }
        }

        private void PrepararOperacion(string op)
        {
            if (huboError) return;

            if (!TryLeer(out var actual))
                return;

            if (operacion == null)
            {
                acumulado = actual;
            }
            else if (!iniciarNuevaEntrada) // cadena op con otro número ya ingresado
            {
                if (!AplicarOperacion(actual))
                    return; // si hubo error (p.ej., div/0)
            }

            operacion = op;
            iniciarNuevaEntrada = true;
        }

        private bool AplicarOperacion(decimal operando)
        {
            try
            {
                decimal resultadoAnterior = acumulado;

                switch (operacion)
                {
                    case "+": acumulado = acumulado + operando; break;
                    case "-": acumulado = acumulado - operando; break;
                    case "*": acumulado = acumulado * operando; break;
                    case "/":
                        if (operando == 0m)
                            throw new DivideByZeroException();
                        acumulado = acumulado / operando;
                        break;
                    default: acumulado = operando; break;
                }
                Mostrar(acumulado);

                if (!string.IsNullOrEmpty(operacion))
                {
                    string operacionCompleta = $"{resultadoAnterior} {operacion} {operando}";
                    string resultadoStr = acumulado.ToString("G29", CultureInfo.InvariantCulture);
                    //Se guarda la operacion en la base de datos
                    ConexionBD.GuardarOperacion(operacionCompleta, resultadoStr);
                }
                return true;
            }
            catch (DivideByZeroException)
            {
                calculo.Text = "Error";
                huboError = true;
                operacion = null;
                iniciarNuevaEntrada = true;
                return false;
            }
        }

        private void LimpiarTodo()
        {
            acumulado = 0m;
            operacion = null;
            iniciarNuevaEntrada = true;
            huboError = false;
            calculo.Text = "0";
        }

        // === Eventos ===

        // Display (si decides permitir edición manual, aquí podrías validar)
        private void calculo_TextChanged(object sender, EventArgs e)
        {
            // Mantén el comportamiento simple: el display solo muestra.
            // Si el usuario escribe a mano, intentamos validar número.
            if (huboError) return;

            string t = calculo.Text.Trim();

            // Evita strings vacíos
            if (t.Length == 0)
            {
                calculo.Text = "0";
                calculo.SelectionStart = calculo.Text.Length;
                return;
            }

            // Normaliza separador decimal a "."
            if (t.Contains(","))
            {
                t = t.Replace(',', '.');
                calculo.Text = t;
                calculo.SelectionStart = calculo.Text.Length;
            }
        }

        // === Botones de borrado ===

        // CE: limpia solo la entrada actual
        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (huboError) { LimpiarTodo(); return; }
            calculo.Text = "0";
            iniciarNuevaEntrada = true;
        }

        // C: limpia todo (estado + display)
        private void Clear_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        // === Unarios ===

        private void cuadrado_Click(object sender, EventArgs e)
        {
            if (huboError) return;
            if (!TryLeer(out var x)) return;
            var r = x * x;
            Mostrar(r);

            //Guardar operacion al cuadrado en la base de datos
            string operacionCuadrado = $"{x} ^ 2";
            string resultadoStr = r.ToString("G29", CultureInfo.InvariantCulture);
            ConexionBD.GuardarOperacion(operacionCuadrado, resultadoStr);

            iniciarNuevaEntrada = true;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (huboError) return;
            if (!TryLeer(out var x)) return;

            if (x < 0m)
            {
                calculo.Text = "Error";
                huboError = true;
                iniciarNuevaEntrada = true;
                operacion = null;
                return;
            }

            double r = Math.Sqrt((double)x);
            Mostrar((decimal)r);

            //Guardar operacion de raiz en la base de datos
            string operacionRaiz = $"sqrt({x})";
            string resultadoStr = ((decimal)r).ToString("G29", CultureInfo.InvariantCulture);

            ConexionBD.GuardarOperacion(operacionRaiz, resultadoStr);

            iniciarNuevaEntrada = true;
        }

        private void masmenos_Click(object sender, EventArgs e)
        {
            if (huboError) return;
            if (!TryLeer(out var x)) return;
            x = -x;
            Mostrar(x);
        }

        // === Dígitos ===
        private void cero_Click(object sender, EventArgs e) => AppendDigito("0");
        private void uno_Click(object sender, EventArgs e) => AppendDigito("1");
        private void dos_Click(object sender, EventArgs e) => AppendDigito("2");
        private void tres_Click(object sender, EventArgs e) => AppendDigito("3");
        private void cuatro_Click(object sender, EventArgs e) => AppendDigito("4");
        private void cinco_Click(object sender, EventArgs e) => AppendDigito("5");
        private void seis_Click(object sender, EventArgs e) => AppendDigito("6");
        private void siete_Click(object sender, EventArgs e) => AppendDigito("7");
        private void ocho_Click(object sender, EventArgs e) => AppendDigito("8");
        private void nueve_Click(object sender, EventArgs e) => AppendDigito("9");

        private void punto_Click(object sender, EventArgs e)
        {
            if (huboError) return;

            if (iniciarNuevaEntrada)
            {
                calculo.Text = "0.";
                iniciarNuevaEntrada = false;
                return;
            }

            if (!calculo.Text.Contains("."))
                calculo.Text += ".";
        }

        // === Operaciones binarias ===
        private void suma_Click(object sender, EventArgs e) => PrepararOperacion("+");
        private void resta_Click(object sender, EventArgs e) => PrepararOperacion("-");
        private void multiplicacion_Click(object sender, EventArgs e) => PrepararOperacion("*");
        private void division_Click(object sender, EventArgs e) => PrepararOperacion("/");

        // === Igual ===
        private void igual_Click(object sender, EventArgs e)
        {
            if (huboError) { LimpiarTodo(); return; }

            if (!TryLeer(out var actual))
                return;

            if (operacion == null)
            {
                // No hay operación pendiente: reafirma el número mostrado
                Mostrar(actual);
                iniciarNuevaEntrada = true;
                return;
            }

            if (AplicarOperacion(actual))
            {
                // Muestra resultado final y resetea la operación
                operacion = null;
                iniciarNuevaEntrada = true;
            }
        }
    }
}
