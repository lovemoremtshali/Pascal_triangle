using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                // Print leading spaces for alignment
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write("  ");
                }

                // Calculate and print binomial coefficients
                int coeff = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}  ", coeff);
                    coeff = coeff * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
