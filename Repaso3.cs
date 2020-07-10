using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero de datos: ");
            int n = int.Parse(Console.ReadLine());
            int[] valores = new int[n];
            int dato = 0;
            //LEER LOS DATOS 
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("ingrese el dato: ");
                dato= int.Parse(Console.ReadLine());
                if (dato > 0)
                {
                    valores[i] = dato;
                }
                else {
                    Console.WriteLine("no se pudo agregar ");
                }
               
  
            }
            //REEMPLAZAR UN ELEMENTO 
            Console.WriteLine("¿Qué número desea reemplazar?");
            int buscar = int.Parse(Console.ReadLine());
            Console.WriteLine("con que dato deseea reemplazarlo: ");
            int nuevo = int.Parse(Console.ReadLine());
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == buscar)
                {
                    valores[i] = nuevo;
                }

            }
            Console.WriteLine("Los datos quedan como: ");
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }


            //////////////////////////////////////////////////////////////////////////////////
            /*      //BUSCAR UN NUMERO Y RETORNAR LA POSICION 
             Console.WriteLine("¿Qué número desea buscar?" );
             int buscar = int.Parse(Console.ReadLine());
             
             for (int i = 0; i < valores.Length; i++)
             {
                 if (valores[i] == buscar) {
                     Console.WriteLine("el número: " + buscar + " está en la posción: " + i);
                 }

             } */
            /////////////////////////////////////////////////////////////////////////////////////
            /* //ORGANIZAR LOS DATOS ASCENDENTE 
             for (int j = 0; j < valores.Length; j++) 
             {
                 for (int i = 0; i < valores.Length - 1; i++)
                 {
                     if (valores[i] > valores[i + 1])
                     {
                         int temp = valores[i];
                         valores[i] = valores[i + 1];
                         valores[i + 1] = temp;

                     }
                 }
             }
             */
            /* //ORGANIZAR LOS DATOS DESCENDENTE
             for (int j = 0; j < valores.Length; j++)
             {
                 for (int i = 0; i < valores.Length - 1; i++)
                 {
                     if (valores[i] < valores[i + 1])
                     {
                         int temp = valores[i];
                         valores[i] = valores[i + 1];
                         valores[i + 1] = temp;

                     }
                 }
             }

             //IMPRIMIR
             Console.WriteLine("Los datos organizados quedan: ");
             for (int i = 0; i < valores.Length; i++)
             {
              Console.WriteLine( valores[i]);
             } */
        }
    }
}