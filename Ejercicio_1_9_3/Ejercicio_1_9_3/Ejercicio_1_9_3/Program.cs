using System;

namespace Ejercicio_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            int tercerNumero = 0;
            int resultado = 0;

            Console.WriteLine("Introduce el primer numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer numero");
            tercerNumero = Convert.ToInt32(Console.ReadLine());

            resultado = primerNumero + segundoNumero + tercerNumero;

            Console.WriteLine("La suma de {0} mas {1} mas {2} es {3}", primerNumero, segundoNumero, tercerNumero, resultado);
            
        }
    }
}
