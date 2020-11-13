using System;

namespace Ejercicio_2_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Apreta a una tecla del teclado");
            letra = Convert.ToChar(Console.ReadLine());

            switch(letra)
            {
                case ' ':Console.WriteLine("Espacio");
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0': Console.WriteLine("Digito");
                    break;
                case '.':
                case ',':
                case ';':
                case ':': Console.WriteLine("Sigo de puntuación");
                    break;
                default:
                    Console.WriteLine("Otro caracter");
                    break;

            }
        }
    }
}
