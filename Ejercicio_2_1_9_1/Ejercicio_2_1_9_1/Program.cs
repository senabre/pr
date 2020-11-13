using System;

namespace Ejercicio_2_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Escribe un numero del 1 al 5");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1: Console.WriteLine("uno");
                    break;
                case 2: Console.WriteLine("Dos");
                    break;
                case 3: Console.WriteLine("Tres");
                    break;
                case 4: Console.WriteLine("Cuatro");
                    break;
                case 5: Console.WriteLine("Cinco");
                    break;
            }


        }
    }
}
