using System;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo 2 - Leia dois números inteiros e escreva a soma deles
            int n1, n2, soma;

            Console.WriteLine("Escreva o primeiro número: (e tecle ENTER)");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: (e tecle ENTER)");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma de {0} e o {1} tem como resultado {2}", n1, n2, soma);
        }
    }
}
