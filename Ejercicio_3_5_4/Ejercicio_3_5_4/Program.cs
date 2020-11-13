using System;

namespace Ejercicio_3_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            
            Console.WriteLine("Introduce una numero");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce una número");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if ((n1 % 2 == 0) && (n2 % 2 == 0)) 
            Console.WriteLine("Pares");
            else
               Console.WriteLine("Impares");
        }
    }
}
