using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        
            bool menu = true;
            List<String> Lista_Canciones = new List<string>();
            while (menu) {

                

                Console.WriteLine("Bienvenido!!");
                Console.WriteLine("          0.Adicionar nuevas canciones ");
                Console.WriteLine("          1.Mostrar la lista de canciones de forma ascendentemente ");
                Console.WriteLine("          2.Mostrar la lista de canciones de forma descendentemente ");
                Console.WriteLine("          3.Eliminar elementos de la lista");
                Console.WriteLine("          4.Escribir la lista de canciones en un archivo de texto plano");
                Console.WriteLine("          5.Cargar una lista de canciones de un archivo de texto plano");
                Console.WriteLine("¿Qué desea hacer? y cuando termine colocar *");

                String respuesta = Console.ReadLine();
                switch (respuesta) {
                    case "0":
                        Console.WriteLine("Como se llaman las canciones y para terminar ponga #");
                        String cancion = "";//
                        do
                        {
                            cancion = Console.ReadLine();
                            if (cancion == "#") break;
                            if (Lista_Canciones.Contains(cancion))
                            {
                                Console.WriteLine("Está repetida, ingrese otra");
                            }
                            else
                            {
                                Lista_Canciones.Add(cancion);
                            }
                        }
                        while (cancion != "#");
                        foreach (var item in Lista_Canciones)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "1":
                        Lista_Canciones.Sort();
                        foreach (var item in Lista_Canciones)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    case "2":
                        Lista_Canciones.Reverse();
                        foreach (var item in Lista_Canciones)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        Console.WriteLine("¿Qué canción desea eliminar?");
                        Lista_Canciones.Remove(Console.ReadLine());
                        foreach (var item in Lista_Canciones)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "4":
                        break;
                    case "*":
                        Console.WriteLine("Ha terminado, muchas gracias");
                        menu = false;
                        break;
                  
                }
   
            }


           
       
            



         
        } 
    }
}
