using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class AsteriskExampleTwo
    {
        public void ExampleLogic()
        {
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 20; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
