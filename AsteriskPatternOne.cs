using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class AsteriskPatternOne
    {
        public void PatternOneShow()
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
