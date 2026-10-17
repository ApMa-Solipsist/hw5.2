using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5._2
{
    internal class Program
    {
        static uint Fib(uint n)
        {
            if ((n == 0) || (n == 1)) return 1;
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        static void Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
