using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double cumprimento;
        private double largura;
        private bool valido; 

        public void DefinirMedidas(double cumprimento, double largura)
        {
            if (cumprimento > 0 && largura > 0)
            {
                this.cumprimento = cumprimento;
                this.largura = largura;
                valido = true; 
            }
            else
            {
                Console.WriteLine("Medidas inválidas. O comprimento e a largura devem ser maiores que zero.");
                valido = false; 
            }
        }            
        public double Area()
        {
            if (valido)
            {
                return cumprimento * largura;
            }
            else
            {
                Console.WriteLine("Não é possível calcular a área. As medidas do retângulo são inválidas.");
                return 0; 
            }
        }
    }
}