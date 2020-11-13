using System;

namespace Ejercicio_3_3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char priLetra = 'a';
            char segLetra = 'b';
            char terLetra = 'c';
            char cuarLetra = 'd';

            Console.Write("Escribe una letra:");
            priLetra = Convert.ToChar(Console.ReadLine());

            Console.Write("Escribe una letra:");
            segLetra = Convert.ToChar(Console.ReadLine());

            Console.Write("Escribe una letra:");
            terLetra = Convert.ToChar(Console.ReadLine());

            Console.Write("Escribe una letra:");
            cuarLetra = Convert.ToChar(Console.ReadLine());

            Console.Write("\"{0}{1}{2}{3}\"", cuarLetra, terLetra, segLetra, priLetra);
        }
    }
}
