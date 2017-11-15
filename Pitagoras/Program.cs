using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero del tamaño de la piramide: ");
            int num = int.Parse(Console.ReadLine());
            int[,] Pascal = new int[num, num];
            for (int x = 0; x < num; x++)
            {
                Pascal[x, 0] = 1;
                Pascal[x, x] = 1;
            }
            for (int a = 2; a < num; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    Pascal[a, b] = Pascal[a - 1, b] + Pascal[a - 1, b - 1];

                }
            }
            for (int a = 0; a < num; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(" | " + Pascal[a, b] + " | ");
                    if (a == b)
                        Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }

}