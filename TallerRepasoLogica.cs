using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 1 

            /*Console.WriteLine("ingrese el tamaño de los arreglos: ");
            int n = int.Parse(Console.ReadLine());

            int[] valores1 = new int[n];
            int[] valores2 = new int[n];
            bool sonIguales = true;
            for (int i = 0; i < valores1.Length; i++)
            {
                Console.WriteLine("ingrese el dato en la posición " + i + " " + "para el primer arreglo");
                valores1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < valores2.Length; i++)
            {
                Console.WriteLine("ingrese el dato en la posición " + i + " " + "para el segundo arreglo");
                valores2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < valores1.Length; i++)
            {

                if (valores1[i] != valores2[i])
                {
                    sonIguales = false;
                }

            }
            if (sonIguales) { Console.WriteLine("Son iguales"); }
            else
            {
                Console.WriteLine("Son diferentes");
            }*/

            //Punto 2 
            /*Console.WriteLine("ingrese la cantidad de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de columnas");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            int[] salida = new int[filas];

            //leer una matriz 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("\nIngresar el dato en la posición [" + i + "," + j + "] =");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }
            //sumar columnas 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    salida[j] += matriz[i, j];
                }

            }
            for (int i = 0; i < salida.Length; i++)
            {
                Console.Write( salida[i] + ", " );

            }  */

            //Tercer punto
            /* Console.WriteLine("ingrese el tamaño de los arreglos: ");
             int n = int.Parse(Console.ReadLine());
             int[] valores = new int[n];
             for (int i = 0; i < valores.Length; i++)
             {
                  Console.Write("Ingresar el dato que desee en la posición "+ i + ": ");
                    valores[i] = int.Parse(Console.ReadLine());

             }
             for (int i = 0; i < valores.Length; i++)
             {
               Console.WriteLine( Mensaje(i, valores[i]));
             }
             */

            //Cuarto Punto 
            /*int x = Ingresar();
            int y = Ingresar();
            sumar(x, y);*/

            //Quinto Punto 
            var Restaurantes = File.ReadAllLines("Restaurantes.txt");
            foreach (var name in Restaurantes)
            {
                Console.WriteLine(name);

            }



        }
        /*static String Mensaje(int posición, int numero)
        {
            String salida = "";
            salida = posición+ ":"+ numero*numero;
            return salida; 
        }
        */
        static int Ingresar() {
            int num = 0;
            Console.WriteLine("Ingresa el dato que desee: ");
            num = int.Parse(Console.ReadLine());
            return num;


        }
        static void sumar(int _A, int _B)
        {
            int suma = _A + _B;
            String Mensaje = _A + " + " + _B + " = " + suma;
            Console.WriteLine(Mensaje);
            Texto(Mensaje);
        }
        static void Texto(String T)
        {
            using (StreamWriter w = File.AppendText("myFile.txt"))
            {
                w.WriteLine(T);
            }
        }

    }
}
