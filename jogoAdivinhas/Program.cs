using System;

namespace jogoAdivinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            string pergunta1;
            int cont = 0;

            Console.WriteLine("Quantos planetas Terra cabem dentro do Sol?" + "\n" + "Escolha um dos seguintes numeros para validar a sua resposta" + "\n" + "1) Um milhão \n" + "2) Cem \n" + "3) Seiscentos \n");
            pergunta1 = Console.ReadLine();
            if (int.Parse(pergunta1) == 3)
            {
                cont++;
            }
            Console.WriteLine("Em que lugar vivem mais cangurus do que pessoas?" + "\n" + "Escolha um dos seguintes numeros para validar a sua resposta" + "\n" + "1) Indonésia \n" + "2) Nova Zelândia \n" + "3) Austrália \n");
            pergunta1 = Console.ReadLine();
            if (int.Parse(pergunta1) == 3)
            {
                cont++;
            }
            Console.WriteLine("Quantos olhos a maior parte das aranhas têm?" + "\n" + "Escolha um dos seguintes numeros para validar a sua resposta" + "\n" + "1) Dois \n" + "2) Quatro \n" + "3) Quatro pares \n");
            pergunta1 = Console.ReadLine();
            if (int.Parse(pergunta1) == 3)
            {
                cont++;
            }
            Console.WriteLine("O que mede a Escala Mercalli?" + "\n" + "Escolha um dos seguintes numeros para validar a sua resposta" + "\n" + "1) A intensidade dos ventos \n" + "2) A intensidade sísmica de acordo com os danos provocados \n" + "3) A resistência dos minerais \n");
            pergunta1 = Console.ReadLine();
            if (int.Parse(pergunta1) == 3)
            {
                cont++;
            }
            Console.WriteLine("Você acertou " + cont + " em 4");
        }
    }
}
