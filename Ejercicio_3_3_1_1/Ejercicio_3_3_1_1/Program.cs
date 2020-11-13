using System;

namespace Ejercicio_3_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            try
            {
                Console.WriteLine("Escribe una letra");
                letra = Convert.ToChar(Console.ReadLine());

                if (letra == 'a')
                    Console.WriteLine("La letra introducida es una vocal");
                else
                    if (letra == 'e')
                    Console.WriteLine("La letra introducida es una vocal");
                else
                     if (letra == 'i')
                    Console.WriteLine("La letra introducida es una vocal");
                else
                    if (letra == 'o')
                    Console.WriteLine("La letra introducida es una vocal");
                else
                    if (letra == 'u')
                    Console.WriteLine("La letra introducida es una vocal");
                else
                    Console.WriteLine("La letra introducida es una consonante");
            }
            catch
            {
                Console.WriteLine("solo puedes itroducir una letra");
            }
        }
    }
}
