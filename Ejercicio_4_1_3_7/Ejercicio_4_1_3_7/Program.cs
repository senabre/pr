using System;

namespace Ejercicio_4_1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre= new string[100];
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("Nombre {0}", i + 1);
                nombre[i] = Convert.ToString(Console.ReadLine());

                if (nombre[i] == "")
                {
                    Console.Write("Los nombres que has introducido son :");
                    for (int j = 0; j < i; j++)
                        Console.Write("{0},",nombre[j]);
                    break;
                }
            }
            
        }
    }
}
