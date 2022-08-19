/*
 * Reto #14
 * ¿ES UN NÚMERO DE ARMSTRONG?
 * Fecha publicación enunciado: 04/04/22
 * Fecha publicación resolución: 11/04/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Escribe una función que calcule si un número dado es un número de Amstrong (o también llamado narcisista).
 * Si no conoces qué es un número de Armstrong, debes buscar información al respecto.
 */

using System;

namespace ARMSTRONG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(371));
            Console.WriteLine(IsArmstrong(-371));
            Console.WriteLine(IsArmstrong(372));
            Console.WriteLine(IsArmstrong(1135));
            Console.WriteLine(IsArmstrong(407));
            Console.WriteLine(IsArmstrong(0));
            Console.ReadKey();
        }

        private static bool IsArmstrong(int number)
        {
            if (number < 0)
                return false;
            else
            {
                var sum = 0;
                var powValue = number.ToString().Length;

                for (int i = 0; i < number.ToString().Length; i++)
                {
                    double value = Convert.ToDouble(new string(number.ToString()[i], 1));
                    sum += (int)Math.Pow(value, powValue);
                }

                return number == sum;
            }
        }
    }
}
