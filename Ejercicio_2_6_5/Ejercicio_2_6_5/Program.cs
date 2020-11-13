using System;

namespace Ejercicio_2_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int altoLeido = 0;
            int inicial = 0;
            int inicial2 = 0;

            Console.Write("Introduce el alto:");
            altoLeido = Convert.ToInt32(Console.ReadLine());

            for (inicial = 1; inicial <= altoLeido; inicial++)
            {
                for (inicial2 = 1; inicial2 <= altoLeido; inicial2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                        
                    
        }
    }
}
