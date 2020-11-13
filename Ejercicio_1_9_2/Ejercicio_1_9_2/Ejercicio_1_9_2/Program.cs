using System;

namespace Ejercicio_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            int resultado = 0;
            int resto = 0;

             Console.WriteLine("Introduce el primer numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            resultado = primerNumero / segundoNumero;
            resto = primerNumero % segundoNumero;

            Console.WriteLine("La divison de {0} entre {1} es {2}", primerNumero, segundoNumero, resultado);
            Console.WriteLine("El resto de la disvision es {0}", resto);
        }
    }
}
