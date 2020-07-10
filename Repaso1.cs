using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 1;
            int a = 0 ;
            int b = 1;
            int limite= 0;
            Console.WriteLine("Ingrese el número limmite");
            limite = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < limite; i++) {
                Console.WriteLine(suma);
                suma = a + b;
                a = b;
                b = suma;
               
                if (suma > 1000) {
                    break; 
                }
            }
        }
    }
}
