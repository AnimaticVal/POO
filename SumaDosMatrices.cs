using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR AMBAS MATRICES 
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matrizRes = new int[4, 4];
            Random random = new Random();
            //filas y columnas de recorren con (la matriz).GetLength(0)(1)
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0;  j < matriz1.GetLength(1); j++)
                {
                    matriz1[i,j] = random.Next(0, 8);
                    matriz2[i, j] = random.Next(0, 8);
                }
            }

            //SUMAR LAS MATRICES 
            for (int i = 0; i < matrizRes.GetLength(0); i++)
            {
                for (int j = 0; j < matrizRes.GetLength(1); j++)
                {
                    matrizRes[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz uno");
            //IMPRIMIR LA MATRIZ 1
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("|" + matriz1[i,j]);
                }
                Console.Write("|\n");
            }
            Console.Write("|\n\n");//DEJAR UN RENGLON
            Console.WriteLine("Matriz dos ");
            //IMPRIMIR LA MATRIZ 2
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("|" + matriz2[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("|\n\n");//DEJAR UN RENGLON
            //IMPRIMIR LA MATRIZ DE LA SUMA 
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("|" + matrizRes[i, j]);
                }
                Console.Write("|\n");
            }
        }
    }
}
