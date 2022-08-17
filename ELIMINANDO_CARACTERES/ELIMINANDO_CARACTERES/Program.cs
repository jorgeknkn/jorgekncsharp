/*
 * Reto #11
 * ELIMINANDO CARACTERES
 * Fecha publicación enunciado: 14/03/22
 * Fecha publicación resolución: 21/03/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea una función que reciba dos cadenas como parámetro (str1, str2) e imprima otras dos cadenas como salida (out1, out2).
 * - out1 contendrá todos los caracteres presentes en la str1 pero NO estén presentes en str2.
 * - out2 contendrá todos los caracteres presentes en la str2 pero NO estén presentes en str1.
 */

using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNonCommon("brais", "moure");
            PrintNonCommon("Me gusta Java", "Me gusta Kotlin");
            PrintNonCommon("Usa el canal de nuestro discord (https://mouredev.com/discord) \"\uD83D\uDD01reto-semanal\" para preguntas, dudas o prestar ayuda a la comunidad",
                "Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.");

            // Otra solución utilizando funciones de orden superior
            PrintNonCommonWithFilter("Usa el canal de nuestro discord (https://mouredev.com/discord) \"\uD83D\uDD01reto-semanal\" para preguntas, dudas o prestar ayuda a la comunidad",
        "Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.");

            Console.ReadKey();
        }

        private static void PrintNonCommon(string str1, string str2)
        {
            Console.WriteLine("Out1: " + FindNonCommon(str1, str2));
            Console.WriteLine("Out2: " + FindNonCommon(str2, str1));
        }

        private static string FindNonCommon(string str1, string str2)
        {
            var output = "";

            for (int i = 0; i < str1.Length; i++)
            {
                if (!str2.ToLower().Contains(str1.ToLower()[i]))
                {
                    output += str1.ToLower()[i];
                }
            }
            return output;
        }

        private static void PrintNonCommonWithFilter(string str1, string str2)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            Console.WriteLine("Out1: " + string.Concat(str1.ToLower().Where(c => !str2.ToLower().Contains(c))));
            Console.WriteLine("Out2: " + string.Concat(str2.ToLower().Where(d => !str1.ToLower().Contains(d))));
        }
    }
}
