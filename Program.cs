using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faffafaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
            Console.ReadKey();
        }
        static int Points(int levels)
        {
            int exp = 0;
            for (int i = 0; i < levels; i++)
            {
                exp = i + exp + 1;
            }
            return exp;
        }

    }
}
