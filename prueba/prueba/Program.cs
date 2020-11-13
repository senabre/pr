using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            double segundoNumero = -1;
            string operacion;
            double resultado = 0;
            bool error = true;
            while (error == true)
            {
                try
                {
                    Console.Write("Introduce un número:");
                    resultado = Convert.ToDouble(Console.ReadLine());
                    error = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("-- > Número incorrecto");
                }
            }
            error = true;
            do
                {
                    Console.Write("Introduce una operación:");
                    operacion = Console.ReadLine();

                    switch (operacion)
                    {
                        case "+":
                        while (error == true)
                        {
                            try
                            {
                                Console.Write("Introduce un número:");
                                segundoNumero = Convert.ToDouble(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("-- > Número incorrecto");
                            }
                        }
                        error = true;
                        resultado += segundoNumero;
                            break;
                        case "-":
                        while (error == true)
                        {
                            try
                            {
                                Console.Write("Introduce un número:");
                                segundoNumero = Convert.ToDouble(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("-- > Número incorrecto");
                            }
                        }
                        error = true;
                        resultado -= segundoNumero;
                            break;
                        case "*":
                        while (error == true)
                        {
                            try
                            {
                                Console.Write("Introduce un número:");
                                segundoNumero = Convert.ToDouble(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("-- > Número incorrecto");
                            }
                        }
                        error = true;
                        resultado *= segundoNumero;
                            break;
                        case "/":
                        while (error == true)
                        {
                            try
                            {
                                Console.Write("Introduce un número:");
                                segundoNumero = Convert.ToDouble(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("-- > Número incorrecto");
                            }
                        }
                        error = true;
                        resultado /= segundoNumero;
                            break;
                        case "=":
                            Console.WriteLine("El resultado es {0}", resultado);
                            Console.WriteLine();
                            resultado = 0;

                        while (error == true)
                        {
                            try
                            {
                                Console.Write("Introduce un número:");
                                resultado = Convert.ToDouble(Console.ReadLine());
                                error = false;

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("-- > Número incorrecto");
                            }
                        }
                        error = true;
                        break;
                        default:
                            if (operacion == "s")
                            {
                                break;
                            }
                            Console.WriteLine("--> Operación incorrecta");
                            break;
                    }
                }
                while (operacion != "s");
                {
                    Console.WriteLine("El resultado es {0}", resultado);
                    Console.WriteLine();
                    Console.WriteLine("FIN DEL PROGRAMA");
                }


        }
    }
}

