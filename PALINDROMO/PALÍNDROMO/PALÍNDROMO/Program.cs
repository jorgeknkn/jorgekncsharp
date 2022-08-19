/*
 * Reto #12
 * ¿ES UN PALÍNDROMO?
 * Fecha publicación enunciado: 21/03/22
 * Fecha publicación resolución: 28/03/22
 * Dificultad: MEDIA
 *
 * Enunciado: Escribe una función que reciba un texto y retorne verdadero o falso (Boolean) según sean o no palíndromos.
 * Un Palíndromo es una palabra o expresión que es igual si se lee de izquierda a derecha que de derecha a izquierda.
 * NO se tienen en cuenta los espacios, signos de puntuación y tildes.
 * Ejemplo: Ana lleva al oso la avellana.
 */

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PALÍNDROMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Ana lleva al oso la avellana."));
            Console.WriteLine(IsPalindrome("Adivina ya te opina, ya ni miles origina, ya ni cetro me domina, ya ni monarcas, a repaso ni mulato carreta, acaso nicotina, ya ni cita vecino, anima cocina, pedazo gallina, cedazo terso nos retoza de canilla goza, de pánico camina, ónice vaticina, ya ni tocino saca, a terracota luminosa pera, sacra nómina y ánimo de mortecina, ya ni giros elimina, ya ni poeta, ya ni vida"));
            Console.WriteLine(IsPalindrome("¿Qué os ha parecido el reto?"));
            Console.ReadKey();
        }

        private static bool IsPalindrome(string txt)
        {
            txt = new string(txt.Where(c => !char.IsPunctuation(c)).ToArray());
            txt = Regex.Replace(txt.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            txt = txt.ToLower().Replace(" ", "");
            int cont = 0;
            bool igual = true;

            for (int i = txt.Length - 1; i >= 0; i--)
            {
                if (txt[i] != txt[cont])
                {
                    igual = false;
                    break;
                }
                cont++;
            }
            return igual;
        }
    }
}
