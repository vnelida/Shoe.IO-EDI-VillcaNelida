﻿using Shoes.Entidades;

namespace Shoes.Shared
{
    public static class ConsoleExtensions
    {
        public static string ReadString(string message)
        {
            string? stringVar = string.Empty;
            while (true)
            {

                Console.Write(message);
                stringVar = Console.ReadLine();
                if (stringVar == null)
                {
                    Console.WriteLine("Debe ingresar algo!!!");
                }
                else
                {
                    break;
                }
            }
            return stringVar;
        }

        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }

        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }
        public static decimal ReadDecimal(string message, decimal min, decimal max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }

                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void EsperaEnter()
        {
            Console.WriteLine("Presion enter para continuar");
            Console.ReadLine();

        }

        public static string GetValidOptions(string message, List<string>? options)
        {
            string answer = string.Empty;
            if (options != null)
            {
                options.Insert(0, "N");
                do
                {
                    answer = ReadString(message);

                    if (!options.Any(x => x.Equals(answer)))
                    {
                        Console.WriteLine("Ingreso no valido. Intentelo nuevamente   ");
                    }
                    else
                    {
                        /*
                         * Si la opción tipiada es alguna de la lista, salgo del ciclo
                         */
                        break;

                    }

                } while (!options.Any(x => x.Equals(answer)));// mientras no sea un caracter válido me quedo esperando

            }
            return answer; //retorno el caracter ingresado y validado.

        }

        public static int SelectFromList<T>(List<T> lista, int minValue, int maxValue) where T : class
        {
            int seleccion = 0;
            Console.Write("Seleccione de la lista");
            foreach (var item in lista)
            {
                switch (item)
                {
                    case Color color:
                        Console.WriteLine($"{color.ColorId} - {color.ColorName}");
                        break;
                    case Genre genre:
                        Console.WriteLine($"{genre.GenreId} - {genre.GnereName}");
                        break;
                    case Sport sport:
                        Console.WriteLine($"{sport.SportiD} - {sport.SportName}");
                        break;
                    case Brand brand:
                        Console.WriteLine($"{brand.BrandId} - {brand.BrandName}");
                        break;
                    default:
                        throw new ArgumentException("Tipo no compatible.");
                }
                Console.WriteLine(); // Agregar una línea en blanco entre los elementos
            }

            seleccion = ReadInt("Selecciona una opción del listado:", minValue, maxValue);

            return seleccion; // Devolver un valor por defecto

        }
        public static int ReadInt(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }
    }
}
