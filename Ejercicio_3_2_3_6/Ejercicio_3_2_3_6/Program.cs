using System;

namespace Ejercicio_3_2_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double resul = 0;
            double espa = 0;
            for (num= 1; num <= 10; num++)
            {
                resul = Math.Pow(num - 5, 2);
                for (espa = 0; espa < resul; espa++)
                {
                    Console.Write(" ");
                   
                }
                Console.WriteLine("*");
            }
            
        }
    }
}
