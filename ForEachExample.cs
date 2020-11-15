using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    public class ForEachExample
    {
        public void ExampleCode()
        {
            List<string> names = new List<string>();
            names.Add("aaaaa");
            names.Add("bbbbbb");
            names.Add("cc");
            names.Add("dddd");
            names.Add("aaaaa");
            names.Add("eeeeee");
            names.Add("aaaaa");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        public void ExampleCodeTwo()
        {
            string[] names = new string[] { "kkkk","ffffff","eeee","aaaa","qqqqqq"};

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
