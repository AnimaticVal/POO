using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double costo = 0;
            int minExtra = 0;
            Console.WriteLine("Ingrese la cantidad de minutos de la llamada");
            int min= int.Parse(Console.ReadLine());
            if (min <= 3)
            {
                costo = 0.50;
                Console.WriteLine("la llamada es de: " + costo);
            }
            else if (min > 3) {
                minExtra = min - 3;
                costo = 0.50 + (minExtra * 0.50);
                Console.WriteLine("la llamada es de: " + costo);
            }
        }
    }
}
