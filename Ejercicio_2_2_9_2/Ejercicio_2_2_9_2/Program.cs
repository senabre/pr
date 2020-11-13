using System;

namespace Ejercicio_2_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int i = -1;
            int max = 0;
            


            Console.WriteLine("Número: 1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número: 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            max = (n1 > n2 ? n1 : n2);

            for (i = 1; i <= max; i++)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    Console.WriteLine(i);
                }
                    }
                     
            
        }
    }
}
