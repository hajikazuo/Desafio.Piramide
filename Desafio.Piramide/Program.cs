using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Piramide
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nDigite o número de linhas da pirâmide: ");
                int n = VerificaNumero(3, 8);
                Console.WriteLine("\n");

                Desenhar(n);

                Console.WriteLine("Deseja continuar? (S/N)");
                if (Console.ReadLine().ToUpper() == "N")
                    break;
            }
        }

        private static int VerificaNumero(int min, int max)
        {
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n >= min && n <= max)
                {
                    break;
                }
                Console.WriteLine($"Número inválido! Digite um número entre {min} e {max}.");
            }
            return n;
        }

        private static void Desenhar(int n)
        {
            Console.WriteLine("\n===========================================\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n===========================================\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n===========================================\n");
        }
    }
}
