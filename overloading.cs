using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    public class overloading
    {
        public void DisplayOverload(int a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }
        public void DisplayOverload(string a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }
        public void DisplayOverload(string a, int b)
        {
            System.Console.WriteLine("DisplayOverload " + a + b);
        }
    }
}
