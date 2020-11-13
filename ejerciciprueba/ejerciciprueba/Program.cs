using System;

namespace ejerciciprueba
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            int i = 0;
            int x = 9;
            for (i = 1; i <= 10; i++)
            {
                for (int l = 0; l <= x; l++)
                {
                    Console.Write(" ");
                }
                x--;
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
