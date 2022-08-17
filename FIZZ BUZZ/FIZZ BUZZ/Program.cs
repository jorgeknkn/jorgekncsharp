/*
 * Reto #0
 * EL FAMOSO "FIZZ BUZZ"
 * Fecha publicación enunciado: 27/12/21
 * Fecha publicación resolución: 03/01/22
 * Dificultad: FÁCIL
 * Enunciado: Escribe un programa que muestre por consola (con un print) los números de 1 a 100 (ambos incluidos y con un salto de línea entre cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */
using System;
using System.Linq;

namespace FIZZ_BUZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = new int[100];
            collection = FillArrayInt();

            foreach (var item in collection)
            {
                var divisibleByThree = item % 3 == 0;
                var divisibleByFive = item % 5 == 0;

                if (divisibleByThree && divisibleByFive)
                {
                    Console.WriteLine("fizzbuzz!");
                }
                else if (divisibleByThree)
                {
                    Console.WriteLine("fizz!");
                }
                else if (divisibleByFive)
                {
                    Console.WriteLine("buzz!");
                }
                else
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
        }

        private static int[] FillArrayInt()
        {
            return Enumerable.Range(1, 100).ToArray();
        }
    }
}
