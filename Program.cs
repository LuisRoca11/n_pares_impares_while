// Desarrollar un programa que permita cargar n números enteros y luego nos informe cuántos valores fueron pares y cuántos impares.
// Emplear el operador “%” en la condición de la estructura condicional:
// if (valor%2==0)         //Si el if da verdadero luego es par.

using System;

namespace n_pares_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, pares = 0, impares = 0, fin = 1;

            while (fin == 1)
            {
                Console.Write("Ingrese un numero entero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }

                Console.Write("Seguir ingresando numeros (si=1 no=0)");
                fin = int.Parse(Console.ReadLine());

                
            }

                Console.WriteLine($"La cantidad de numeros pares es: {pares}");
                Console.WriteLine($"La cantidad de numeros impares es: {impares}");

            Console.ReadKey();


        }
    }
}