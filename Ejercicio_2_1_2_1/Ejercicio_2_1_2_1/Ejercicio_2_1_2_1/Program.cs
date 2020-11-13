using System;

namespace Ejercicio_2_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int segundoNumero = 0;

            Console.WriteLine("Introduce un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 10 == 0)

                Console.WriteLine("{0} es multiplo de 10", numero);
            else
                Console.WriteLine("{0} no es multiplo de 10", numero);
            

                    Console.WriteLine("Introduce otro un numero");
                    segundoNumero = Convert.ToInt32(Console.ReadLine());

                        if (segundoNumero % 10 == 0)
                            Console.WriteLine("{0} es multiplo de 10", segundoNumero);
                        else
                            Console.WriteLine("{0} no es multiplo de 10", segundoNumero);
        }
    }
}
