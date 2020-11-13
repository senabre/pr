using System;

namespace Ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int numeroleido =  0;
            
            
            Console.Write("Introduce un número:");
            numero = Convert.ToInt32(Console.ReadLine());
            /*
            for(int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                    numero = numero / i;
                    i = 1;
                }
            }

            Console.WriteLine("-----------------");
            */
            int divisor = 2;
            
            while (numeroleido != 1)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    numero = numero / divisor;
                }
                else
                    divisor++;
            }



        }
    }
}
