using System;

namespace Ejercicio_3_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            char letraInicial;
            Console.WriteLine("Letra");
            letra = Convert.ToChar(Console.ReadLine());

            for (letraInicial = letra; letraInicial <= 'z'; letraInicial++, letraInicial++)
            {
                
                Console.Write(letraInicial);
                
                
            }
            

        }
    }
}
