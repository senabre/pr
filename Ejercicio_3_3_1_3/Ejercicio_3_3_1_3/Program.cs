using System;

namespace Ejercicio_3_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto = 0;
            int ancho = 0;
            char letra = 'a';

            Console.WriteLine("Introduce el alto");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el caracter para formar el cuadrado");
            letra = Convert.ToChar(Console.ReadLine());

            for (int altoactual = 0; altoactual < alto; altoactual++)
            {
                for (int anchoactual = 0; anchoactual < ancho; anchoactual++)
                {
                    Console.Write(letra);
                        }
                Console.WriteLine();
                        }

        }
    }
}
