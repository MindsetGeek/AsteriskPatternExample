using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class NumberPatternOne
    {
        public void NumberPatternPrint()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= (9-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = (i-1); j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void NumberPatternPrintTwo()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
