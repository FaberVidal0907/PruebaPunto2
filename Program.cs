using System;
using System;
using System.Collections.Generic;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elementos = new List<int>();
        
           
            while (Console.ReadKey().Key != ConsoleKey.S) {
                 Console.WriteLine("Inserte elemento: ");
                 elementos.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in elementos)
            {
                Console.WriteLine("Elemento Insertado:"+item);
            }
             Console.WriteLine("Elija Operacion: Mayor a menor : presione 1 ");
             Console.WriteLine("Elija Operacion: Menor a mayor : presione 2 ");
             Console.WriteLine("Elija Operacion: Buscar un elemento : presione 3 ");
             Console.WriteLine("Elija Operacion: Agregar Elemento : presione 4 ");
             Console.WriteLine("Elija Operacion: Listar repetidos : presione 5 ");
             switch (Convert.ToInt32(Console.ReadLine()))
             {
                case 1:
                 elementos.Sort();
                 foreach (var item in elementos)
                 {
                    Console.WriteLine(item);
                 }
                break;
                case 2:
                break;
                case 3:
                Console.WriteLine("Numero a Buscar:");
                int num = elementos.IndexOf(Convert.ToInt32(Console.ReadLine()));
                if (num > 0)
                Console.WriteLine($"Elemento es: {num}");
                else
                Console.WriteLine("No se Encuentra!");
                break;
                case 4:
                break;
                case 5:
                
                foreach (var item in elementos)
                 {
                    foreach (var item2 in elementos)
                    {
                        if(item==item2){
                          Console.WriteLine(item);
                        }
                        
                    }
                    
                 }
                    
                
                
                break;
                
             }
           

        }
    }
}
