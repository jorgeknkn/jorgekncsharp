/*
 * Reto #10
 * EXPRESIONES EQUILIBRADAS
 * Fecha publicación enunciado: 07/03/22
 * Fecha publicación resolución: 14/03/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que comprueba si los paréntesis, llaves y corchetes de una expresión están equilibrados.
 * - Equilibrado significa que estos delimitadores se abren y cieran en orden y de forma correcta.
 * - Paréntesis, llaves y corchetes son igual de prioritarios. No hay uno más importante que otro.
 * - Expresión balanceada: { [ a * ( c + d ) ] - 5 }
 * - Expresión no balanceada: { a * ( c + d ) ] - 5 }
 */

using System;
using System.Collections.Generic;

namespace EXPRESIONES_EQUILIBRADAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanced("{a + b [c] * (2x2)}}}}"));
            Console.WriteLine(IsBalanced("{ [ a * ( c + d ) ] - 5 }"));
            Console.WriteLine(IsBalanced("{ a * ( c + d ) ] - 5 }"));
            Console.WriteLine(IsBalanced("{a^4 + (((ax4)}"));
            Console.WriteLine(IsBalanced("{ ] a * ( c + d ) + ( 2 - 3 )[ - 5 }"));
            Console.WriteLine(IsBalanced("{{{{{{(}}}}}}"));
            Console.WriteLine(IsBalanced("(a"));
            Console.ReadKey();
        }

        private static bool IsBalanced(string expression)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '{' || expression[i] == '(' || expression[i] == '[')
                    st.Push(expression[i]);

                if (expression[i] == '}' || expression[i] == ')' || expression[i] == ']')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else if (!IsMatchingPair(st.Pop(), expression[i]))
                    {
                        return false;
                    }
                }
            }

            if (st.Count == 0)
                return true; // balanced
            else
            {
                // not balanced
                return false;
            }
        }

        static bool IsMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }
    }
}
