using System;

namespace Ejercicio_2_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (cont=1; cont <= 50; cont++)
               if (cont % 3 == 0)
                    Console.WriteLine("{0}",cont);
        }
    }
}
