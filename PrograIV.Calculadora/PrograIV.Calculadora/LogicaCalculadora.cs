using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.Calculadora
{
    public class LogicaCalculadora
    {
        /// <summary>
        /// Esta función es la cara de la interfaz para hacer el cálculo de las operaciones.
        /// </summary>
        /// <param name="elPrimerOperando">Hilera de caracteres que representa el primer operando.</param>
        /// <param name="elSegundoOperando">Hilera de caracteres que representa el segundo operando.</param>
        /// <param name="elOperador">Hilera de caracteres que representa el operador.</param>
        /// <returns>Hilera de caracteres que representa el resultado de la operación.</returns>
        public string RealizarOperacion (string elPrimerOperando, string elSegundoOperando, string elOperador)
        {
            double miPrimerOperando = Convert.ToDouble(elPrimerOperando);
            double miSegundoOperando = Convert.ToDouble(elSegundoOperando);
            EnumeradoOperadores elOperadorEnumerado = ConvertirStringEnEnumeradoOperadores(elOperador);
            double? elResultado = RealizarOperacion(miPrimerOperando, miSegundoOperando, elOperadorEnumerado);
            string elResultadoConvertido;
            if (elResultado != null)
            {
                elResultadoConvertido = elResultado.ToString();
            }
            else
                elResultadoConvertido = "Error en el cálculo";
            return elResultadoConvertido;
        }

        private EnumeradoOperadores ConvertirStringEnEnumeradoOperadores (string elOperador)
        {
            EnumeradoOperadores elResultado;
            switch (elOperador)
            {
                case "Suma":
                case "Add":
                case "Abarajamelabañera":
                case "subanstrugenbajen":
                case "yanomiromisuzuki":
                case "linchao":
                    elResultado = EnumeradoOperadores.Suma;
                    break;
                case "Resta":
                case "Minus":
                    elResultado = EnumeradoOperadores.Resta;
                    break;
                case "Multiplicación":
                case "Times":
                case "Multiply":
                    elResultado = EnumeradoOperadores.Multiplicacion;
                    break;
                case "División":
                case "Divide":
                    elResultado = EnumeradoOperadores.Division;
                    break;
                default:
                    elResultado = EnumeradoOperadores.Desconocido;
                    break;
            }
            return elResultado;
        }

        private double? RealizarOperacion (double elPrimerOperando, double elSegundoOperando, EnumeradoOperadores elOperador)
        {
            double? elResultado = 0.0;
            switch (elOperador)
            {
                case EnumeradoOperadores.Suma:
                    {
                        elResultado = (elPrimerOperando + elSegundoOperando);
                        break;
                    }
                case EnumeradoOperadores.Resta:
                    {
                        elResultado = (elPrimerOperando - elSegundoOperando);
                        break;
                    }
                case EnumeradoOperadores.Multiplicacion:
                    {
                        elResultado = (elPrimerOperando * elSegundoOperando);
                        break;
                    }
                case EnumeradoOperadores.Division:
                    {
                        if (elSegundoOperando != 0)
                        {
                            elResultado = (elPrimerOperando / elSegundoOperando);
                        }
                        else
                            elResultado = null;
                        break;
                    }
                case EnumeradoOperadores.Desconocido:
                    {
                        elResultado = null;
                        break;
                    }

            }
            return elResultado;
        }
    }
}
