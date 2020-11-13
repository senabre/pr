using System;

namespace Ejercicio_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int metros = 0;
            int millas = 0;
            

            Console.WriteLine("Introduce los metros que quieres convertir");
            metros = Convert.ToInt32( Console.ReadLine() );
            millas = 1609;
            int resultado = metros / millas;

            Console.WriteLine("{0} metros son equivalentes a {1} millas", metros, resultado);
        }
    }
}
