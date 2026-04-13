using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public int subtrair(int a, int b)
        {
            return a - b;
        }
    }
}