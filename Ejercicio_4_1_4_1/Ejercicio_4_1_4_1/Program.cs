using System;

namespace Ejercicio_4_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 10, 0 };
            int capacidad = 5;  
            int i;
            int numero = 0;
            int cont = 0;
            Console.Write("Introduce el número a buscar:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < capacidad; i++)
            {
                if (datos[i] == numero)
                {
                    cont++;
                }
                
            }
            if (cont == 0)
            { 
                Console.WriteLine("{0} se no ha encontrado", numero);
            }
            else
            {
                Console.WriteLine("{0} se ha encontrado {1} veces", numero, cont);
            }
            

        }
    }
}
