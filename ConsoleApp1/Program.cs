using System;

namespace ConsoleApp1
{
    class Program
    {
        public static double captura()
        {
            double nt1, nt2, nt3, menor;

            double media;

            Console.Write("Digite a 1º nota:");
            nt1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a 2º nota:");
            nt2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a 3º nota:");
            nt3 = Convert.ToInt32(Console.ReadLine());

            menor = nt1;

            if (nt2 < menor)
                menor = nt2;

            if (nt3 < menor)
                menor = nt3;


            media = (nt1 + nt2 + nt3 - menor)/2;
            Console.Write("Média: {0}\n\n", media.ToString());

            return media;
        }

        static void Main(string[] args)
        {
            double media_aluno;

            media_aluno = Program.captura();

            if (media_aluno >= 6.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.Write("Reprovado!");
            }

        }
    }
}


