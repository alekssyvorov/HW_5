using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_for_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            for (int i = 1; i < (a / 2+1); i++)
            {
                for (int j = i; j < (a / 2+1); j++)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k < i*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = ((a-1) / 2 + 1); i > 0 ; i--)
            {
                for (int j = i; j < ((a-1) / 2 + 1); j++)
                {
                    Console.Write(' ');
                }
                for (int r = i * 2; r > 1 ; r--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
