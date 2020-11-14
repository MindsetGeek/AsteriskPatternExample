using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class AsteriskExampleThee
    {
        public void PatternPrint()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 20; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
