using System;

namespace vetorStringSubstituiPalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;

            Console.WriteLine("Introduza o tamanho do vetor");
            n = Console.ReadLine();

            string[] vec = new string[int.Parse(n)];

            funcSubstituir(vec, n);
        }

        private static void funcSubstituir(string[] vec, string n)
        {
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine("Introduza o seu nome");
                vec[i] = Console.ReadLine();
                vec[i]=vec[i].Replace('v','b');
            }
            for (int i = 0;i< int.Parse(n); i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
