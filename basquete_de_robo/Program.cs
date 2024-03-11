using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basquete_de_robo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            d = int.Parse(Console.ReadLine());
            if ( d <= 800)
            {
                Console.WriteLine("1");
            }
            else if (800 < d && 1400 >= d)
            {
                Console.WriteLine("2");
            }
            else if ( 1400 < d && 2000 >= d)
            {
                Console.WriteLine("3");
            }
            Console.ReadKey();

        }
    }
}
