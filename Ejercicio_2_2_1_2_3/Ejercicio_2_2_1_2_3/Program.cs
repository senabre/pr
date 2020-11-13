using System;

namespace Ejercicio_2_2_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = -1;
            int Cont = 0;
            Console.WriteLine("introduce un numero entero");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                numero = numero / 10;
                Cont = Cont + 1;
                
            }
            Console.WriteLine("El numero tiene {0} digitos", Cont);

        }
    }
}
