using System;

namespace Ejercicio_2_2_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 26;

            while (numero >= 10)
            {
                if (numero%2==0)
                    Console.WriteLine(numero);
                numero = numero - 1;  
            }
        }
    }
}
