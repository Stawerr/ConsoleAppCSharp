using System;

namespace ConsoleAppCcardinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            string n1;
            string n2;
            int soma;

            //Leitura dos valores
            Console.WriteLine("Digite o N1");
            n1 = Console.ReadLine();
            Console.WriteLine("Digite o N2");
            n2 = Console.ReadLine();

            // Calcular a soma
            soma = int.Parse(n1) + int.Parse(n2);

            //Apresentar resultados
            Console.WriteLine("Soma: " + soma);

        }
    }
}
