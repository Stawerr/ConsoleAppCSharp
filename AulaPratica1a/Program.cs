using System;

namespace AulaPratica1a
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string[] vec = new string[10];
            int i = 0;
            int n = 0;

            Console.WriteLine("Digite o seu nome completo");
            nome = Console.ReadLine();

            //Ir buscar uma terminação numa string

            //bool nome2 = nome.EndsWith("eu");

          //  if (nome2 == true )
           // {
         //       Console.WriteLine("Olá "+nome+" Dá cá o meu!");
           // }
         //   else
          //  {
           //     Console.WriteLine("Olá " + nome + " !");
         //   }
            string[] palavras = nome.Split(' ');

            foreach(string palavra in palavras)
            {
                vec[i] = palavra;
                i++;
                n++;
            }
           // for (i = 0; i < n; i++)
            //{
             //  Console.WriteLine(vec[i]);
            //}
            
            Console.WriteLine(vec[0]+" "+vec[n-1]) ;
        }
    }
}
