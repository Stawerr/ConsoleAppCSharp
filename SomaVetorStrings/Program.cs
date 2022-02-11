using System;

namespace SomaVetorStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("Introduza o tamanho do vetor");
            n= Console.ReadLine();

            string[] vec= new string[int.Parse(n)];

            int maiorFunc = funcMaior(vec, n);

            Console.WriteLine("A soma dos comprimentos é: " + maiorFunc);
        }

        private static int funcMaior(string[] vec, string n)
        {
            int maior = 0;
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine("Escreva o seu nome");
                vec[i]=Console.ReadLine();
                maior = maior + vec[i].Length;
            }
            return maior;
        }
    }
}
