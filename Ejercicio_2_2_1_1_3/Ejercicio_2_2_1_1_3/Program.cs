using System;

namespace Ejercicio_2_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = -1;
            int segundoNumero = -1;
           
            while (primerNumero % segundoNumero == 0)
            {
                Console.WriteLine("Introduce un numero");
                primerNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce un numero");
                segundoNumero = Convert.ToInt32(Console.ReadLine());

                if (primerNumero % segundoNumero == 0)
                    Console.WriteLine("es multiplo");
            }
        }
    }
}
