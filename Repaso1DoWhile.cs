using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 1;
            int a = 0;
            int b = 1;


            do
            {
                Console.WriteLine(suma);
                suma = a + b;
                a = b;
                b = suma;
            } while (suma < 10000);
              
            

        }
    }
}
