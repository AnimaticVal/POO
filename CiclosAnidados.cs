using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosAnidados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i, j, k = 1;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3; j++)
                {

                    Console.WriteLine(k + "" + i + "" + j);

                    k++;
                }

            }*/

            int i;
            for (i = 25 ; i <= 250; i++)
            {
               String Num = i.ToString();
                if (Num.EndsWith("6")) {
                    Console.WriteLine(Num);
  
                }
                
            }

        }
    }
}
