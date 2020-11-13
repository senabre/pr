using System;

namespace Ejercico_2_2_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            for (numero = 20; numero>=10; numero--)
            {
                if (numero == 13)
                    continue;

                Console.WriteLine("{0}", numero);
            }
            
        }
    }
}
