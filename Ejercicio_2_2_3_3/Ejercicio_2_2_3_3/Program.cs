using System;
using System.Runtime.Serialization.Formatters;

namespace Ejercicio_2_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for ( cont= 100; cont<=200; cont++)
                if((cont % 7 == 0) && (cont % 3 == 0))
                    Console.WriteLine("{0}", cont);
        }
    }
}
