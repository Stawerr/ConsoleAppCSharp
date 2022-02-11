using System;

namespace OrdenarVetorAlfabeticamente
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;

            Console.WriteLine("Indique o tamanho do vetor");
            n = Console.ReadLine();

            string[] vec = new string[int.Parse(n)];

            funcaoOrdenaVec(vec, n);
        }

        private static void funcaoOrdenaVec(string[] vec, string n)
        {
            for (int i =0;i< int.Parse(n); i++)
            {
                Console.WriteLine("Escreva uma palavra");
                vec[i] = Console.ReadLine();
            }
            for (int i = 0; i < int.Parse(n); i++)
            {
                Array.Sort(vec, StringComparer.InvariantCulture);
            }
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
