using System;

namespace Ejercicio_2_2_1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = -1;
            int segundoNumero = -1;

            while (primerNumero != 0 || segundoNumero != 0 )
            {
                Console.WriteLine("Introduce un numero");
                primerNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce un numero");
                segundoNumero = Convert.ToInt32(Console.ReadLine());

                if (primerNumero % segundoNumero == 0)
                    Console.WriteLine("{0} es multiplo de {1}", primerNumero, segundoNumero);
                else
                {
                    
                        if (segundoNumero % primerNumero == 0)
                    { 
                        Console.WriteLine("{0} es multiplo de {1}", segundoNumero, primerNumero);
                    }
                        else
                    {
                            Console.WriteLine("Ningun numero es multiplo del otro");
                    }
                }


            }
        }
    }
}
