using System;

namespace Ejercicio_4_1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            int i;
            string nombreBuscar;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Nombre {0}", i + 1);
                nombres[i] = Convert.ToString(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Teclea un nombre");
                nombreBuscar = Convert.ToString(Console.ReadLine());
            
                for (i = 0; i < 10; i++)
                {
                    if (nombreBuscar == nombres[i])
                    {
                        Console.WriteLine("El nombre se ha encontrado en la posición {0}", i + 1);
                        break;
                    }
                    
                }
                if (i == 10)
                    Console.WriteLine("El nombre no se ha encontrado");
                
            }

            while (nombreBuscar != "fin");


        }
            
    }
}
