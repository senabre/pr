using System;

namespace Ejercicio_2_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int veces = 0;
            for (veces = 1; veces <= 5; veces++)
                for (cont = 1; cont <= 5; cont++)
                    Console.Write("{0}", cont);
               
        }
    }
}
