using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class CalculadoraCientifica : Calculadora // Herencia
    {
        public double Potencia(int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

    }
}
