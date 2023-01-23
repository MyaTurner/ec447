using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("{0} {1}", i, n);
                n *= 2;

            }
        }
    }
}
