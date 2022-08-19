/*
 * Reto #13
 * FACTORIAL RECURSIVO
 * Fecha publicación enunciado: 28/03/22
 * Fecha publicación resolución: 04/04/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Escribe una función que calcule y retorne el factorial de un número dado de forma recursiva.
 */

using System;

namespace FACTORIAL_RECURSIVO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(0) == null ? "No tiene factorial" : Factorial(0).ToString());
            Console.WriteLine(Factorial(7) == null ? "No tiene factorial" : Factorial(7).ToString());
            Console.WriteLine(Factorial(10) == null ? "No tiene factorial" : Factorial(10).ToString());
            Console.WriteLine(Factorial(1) == null ? "No tiene factorial" : Factorial(1).ToString());
            Console.WriteLine(Factorial(-1) == null ? "No tiene factorial" : Factorial(-1).ToString());
            Console.ReadKey();
        }

        private static int? Factorial(int n)
        {
            return n < 0 ? null : n <= 1 ? 1 : n * (Factorial(n - 1));
        }
    }
}
