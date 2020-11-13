using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] numero;
            numero = new int[2][];
            int bloque;
            int bloquePrimer;
            int i = -1;
            int j = -1;
            try
            {
                Console.WriteLine("Tamaño que tendrá en bloque 1");
                bloque = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tamaño que tendrá en bloque 2");
                bloquePrimer = Convert.ToInt32(Console.ReadLine());

                numero[0] = new int[bloque];
                numero[1] = new int[bloquePrimer];


                for (i = 0; i < numero.Length; i++)
                {
                    for (j = 0; j < numero[i].Length; j++)
                    {
                        Console.Write("Numero:");
                        numero[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }


                int max = Int32.MinValue;
                for (i = 0; i < numero.Length; i++)
                {
                    for (j = 0; j < numero[i].Length; j++)
                    {
                        if (numero[i][j] > max)
                        {
                            max = numero[i][j];
                        }
                    }
                    Console.WriteLine(max);
                    max = Int32.MinValue;
                }
            }


            catch(FormatException)
            {
                Console.WriteLine("No es un número");
            }

        }
    }
}
