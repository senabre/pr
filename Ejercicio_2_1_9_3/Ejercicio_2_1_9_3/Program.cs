using System;

namespace Ejercicio_2_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Escribe letra o unnumero");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("vocal");
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': Console.WriteLine("digito");
                    break;
                default: Console.WriteLine("consonante");
                    break;





            }
        }
    }
}
