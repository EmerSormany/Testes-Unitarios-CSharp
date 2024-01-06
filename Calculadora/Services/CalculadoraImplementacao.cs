using System;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool ehPar(int num)
        {
            return num % 2 == 0;
        }
    }
}
