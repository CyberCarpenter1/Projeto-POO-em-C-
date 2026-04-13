using System;
using System.Runtime.ConstrainedExecution;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando abstração e herança
            Pessoa p1 = new Pessoa();
            p1.Nome = "João";
            p1.Idade = 30;
            p1.Apresentar();

            Aluno p2 = new Aluno();
            p2.Nome = "Maria";
            p2.Idade = 20;
            p2.Nota = 85;
            p2.Apresentar();

            Professor p3 = new Professor();
            p3.Nome = "Carlos";
            p3.Idade = 40;
            p3.Salario = 5000;
            p3.Apresentar();


        // Utilizando encapsulamento
         Retangulo r = new Retangulo();
        r.DefinirMedidas(5, 3);    
        System.Console.WriteLine($"Área do retângulo: {r.Area()}");

        Retangulo r2 = new Retangulo();
        r2.DefinirMedidas(-2, 4);
        System.Console.WriteLine($"Área do retângulo: {r2.Area()}");

        // Utilizando o polimorfismo (Overload/Override)
        Calculadora calc = new Calculadora();
        System.Console.WriteLine($"Soma de 2 números: {calc.Somar(10, 10)}");
        System.Console.WriteLine($"Soma de 3 números: {calc.Somar(10, 10, 10)}");

        // Utilizando Classes e métodos abstratos
         Corrente c = new Corrente();
         c.Creditar(100);   
         c.ExibirSaldo();

         // Utilizando Interfaces
            ICalculadora calc2 = new Calculadora();
            System.Console.WriteLine($"Multiplicação: {calc2.Multiplicar(10, 10)}");
            System.Console.WriteLine($"Divisão: {calc2.Dividir(10, 10)}");

        // Utilizando Helper (Listando diretórios)
        var caminho = @"C:\Users\olive\Desktop\Projeto C#\TrabalhandoComArquivos";
        FileHelper helper1 = new FileHelper();
        helper1.ListarDiretorios(caminho);

        // Utilizando Helper (Lendo arquivos)
        var arquivos = @"C:\Users\olive\Desktop\Projeto C#\TrabalhandoComArquivos";
        FileHelper helper2 = new FileHelper();
        helper2.ListarArquivos(arquivos);
        }

       
    }
}