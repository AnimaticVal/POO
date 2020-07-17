using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Punto6Op
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!!");
            int opcion = 0;
            List<String> Lista_Canciones = new List<string> {
                "Uno",
                "one",
                "hello world"
            };

            do
            {
                opcion = Menu();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Por favor ingresa el nombre de la nueva canción");
                        String song = Console.ReadLine();
                        var HasSong = Lista_Canciones.Find(x => x.Equals(song));//VALIDAR SI LA LISTA TIENE LA CANCIÓN, retornorá un nulo
                        if (HasSong == null)
                        {
                            Lista_Canciones.Add(song);
                            Console.WriteLine(string.Format("La canción {0} fue agregada con exito", song));
                        }
                        else {
                            Console.WriteLine(string.Format("La canción {0} ya está en la lista", song));
                        }

                        break;
                    case 2:
                        Lista_Canciones.Sort();
                        foreach (var name in Lista_Canciones)
                        {
                            Console.WriteLine(name);
                        } 
                       
                        break;
                    case 3:
                        Lista_Canciones.Sort();
                        Lista_Canciones.Reverse();
                        foreach (var name in Lista_Canciones)
                        {
                            Console.WriteLine(name);
                        }

                        break;
                    case 4:
                        Console.WriteLine("que cancion desea eliminar");
                        String eliminar = Console.ReadLine();
                        var isSong = Lista_Canciones.Remove(eliminar);
                        if (isSong == true)
                        {
                            Console.WriteLine(String.Format("La canción {0} fue eliminada", eliminar));

                        }
                        else {
                            Console.WriteLine(String.Format("La canción {0} no se pudo eliminar", eliminar));
                        }
                        break;
                
                    case 5:
                        Console.WriteLine("que numero de cancion desea actualizar");
                        for (int i  = 1; i  <= Lista_Canciones.Count ; i ++)
                        {
                            Console.WriteLine(string.Format("{0}. {1}",i ,Lista_Canciones[i-1]));
                        }
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el nuevo nombre");
                        String NewName = Console.ReadLine();
                        Lista_Canciones[numero - 1] = NewName;
                        Console.WriteLine("cancion actualizada con exito");
                        break;
                    case 6:
                        StringBuilder sb = new StringBuilder();
                        foreach (var name in Lista_Canciones)
                        {
                            sb.AppendLine(name);
                        }
                        File.WriteAllText("Lista_Canciones_escritas.txt" , sb.ToString());
                        break;
                    case 7:
                        var canciones = File.ReadAllLines("Lista_Canciones_leidas.txt");
                        foreach (var name in canciones)
                        {
                            Console.WriteLine(name);

                        }
                        break;
                    case 8:
                        Console.WriteLine("muchas gracias");
                        break;

                        break;



                    default:
                        break;
                }
            } while (opcion != 8);

        }
        static int Menu() {

            Console.WriteLine("");
            Console.WriteLine("1.Adicionar nuevas canciones y verificar que no esté repetida");
            Console.WriteLine("2.Mostrar la lista de canciones de forma ascendentemente ");
            Console.WriteLine("3.Mostrar la lista de canciones de forma descendentemente ");
            Console.WriteLine("4.Eliminar elementos de la lista");
            Console.WriteLine("5.Actualizar los nombres de las canciones");
            Console.WriteLine("6.Escribir la lista de canciones en un archivo de texto plano");
            Console.WriteLine("7.Cargar una lista de canciones de un archivo de texto plano");
            Console.WriteLine("8.salir");

            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            return opcion;
        }
    }
}
