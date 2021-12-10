using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число больше нуля ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1;
            int s=0;
            
            for ( n1 = 1; n1<=n;n1++)
            {
                s += 2*n1-1;
                Console.WriteLine("квадрат числа {0} равен {1} ", n1, s);
            }
            Console.ReadKey();
        }
    }
}
