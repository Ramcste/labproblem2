using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
               
                if (i%2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
