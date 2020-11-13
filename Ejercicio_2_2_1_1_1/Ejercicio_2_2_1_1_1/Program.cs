using System;

namespace Ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Introduce la contraseña");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 1111)
            {
                Console.WriteLine("contraseña incorrecta, vuelve a introducir la contraseña");
                numero = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
