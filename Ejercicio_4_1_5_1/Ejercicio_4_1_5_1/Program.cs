using System;

namespace Ejercicio_4_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"};
            const int MAXIMO = 12;
            const int SEGUNDOMAXIMO = 11;
            Console.WriteLine("-----Escoge la manera de visualizar los meses-----");
            Console.WriteLine("1---Enero a Diciembre");
            Console.WriteLine("2---Diciembre a Enero");
            Console.Write("Numero:");
            string numero = Console.ReadLine();

            if(numero == "1")
            {
                for (int i = 0; i < MAXIMO; i++)
                    Console.WriteLine(meses[i]);
            }

            if (numero == "2")
            {
                for (int i = SEGUNDOMAXIMO; i > -1; i--)
                    Console.WriteLine(meses[i]);
            }
        }
    }
}

