using System;

namespace Ejercicio_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            int resultado = 0;

            Console.WriteLine("Introduce el primer numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            resultado = primerNumero * segundoNumero;

            Console.WriteLine("El resultado de {0} y {1} es {2}", primerNumero, segundoNumero, resultado);
        }
    }
}
