using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class Calculator
    {
        public void CalcutorStart()
        {
            
            int p = 0;

            while (p!=2)
            {
                Console.Write("Please Enter First Number : ");
                int firstnum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter First Number : ");
                int secondnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum of ( "+ firstnum+" + "+ secondnum + " )"+ (firstnum+ secondnum));

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select the option ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("| 1 - Continue....         |");
                Console.WriteLine("| 2 - Exit....             |");
                Console.WriteLine("----------------------------");
                p = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
