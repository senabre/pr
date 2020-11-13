using System;

namespace Ejercicio_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int millas = 0;
            int metros = 0;
            int resultado = 0;

            Console.WriteLine("Introduce las millas que quieres convertir a metros");
            millas = Convert.ToInt32(Console.ReadLine());

            metros = 1852;

            resultado = millas * metros;

            Console.WriteLine("La millas que has introducido equivalen a {0} metros",resultado);


        }
    }
}
