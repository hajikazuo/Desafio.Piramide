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

                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                if (n >= 3 && n <= 8)
                {
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

                    Console.WriteLine("Deseja continuar? (S/N)");   
                    if (Console.ReadLine().ToUpper() == "N") break;
                }

                else Console.WriteLine("Número de linhas inválido! Digite um número entre 3 e 8. Deseja continuar? (S/N)");
                if (Console.ReadLine().ToUpper() == "N") break;
            }
        }
    }
}
