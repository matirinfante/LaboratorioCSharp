using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1

            int n1 = 10, n2 = 20, n3 = 30;

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"N1 es el mayor: {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"N2 es el mayor: {n2}");
            }
            else if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine($"N3 es el mayor: {n3}");
            }

            #endregion

            #region Ejercicio 2

            int a = -10, b = 2, c = 5;

            if (a > 0 && b > 0)
            {
                Console.WriteLine($"a x b = {a * b}");
            }
            else if (a > 0 && c > 0)
            {
                Console.WriteLine($"a x c = {a * c}");
            }
            else if (b > 0 && c > 0)
            {
                Console.WriteLine($"b x c = {b * c}");
            }

            #endregion

            #region Ejercicio3

            String usuario = "Pepito", contraseña = "1234";

            if (usuario.Equals("Pepito") && contraseña.Equals("1234"))
            {
                Console.WriteLine("Bienvenido Pepito!");
            }
            else if (!(usuario.Equals("Pepito")) & contraseña.Equals("1234"))
            {
                Console.WriteLine("Usuario incorrecto");
            }
            else if (usuario.Equals("Pepe") & !(contraseña.Equals("1234")))
            {
                Console.WriteLine("Contraseña incorrecta");
            }

            #endregion

            #region Ejercicio 4

            int numero1, numero2, opcion;
            Console.WriteLine("Ingrese el primer número: ");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Ingrese el segundo número: ");
            int.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("Ingrese una de las siguientes opciones: ");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - Division\n");
            Console.WriteLine("Opción: ");
            int.TryParse(Console.ReadLine(), out opcion);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Suma: {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"Resta: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplicación: {numero1 * numero2}");
                    break;
                case 4:
                    Console.WriteLine(numero2 > numero1
                        ? $"Division: {(double) numero1 / numero2} con resto: {numero1 % numero2}"
                        : $"División: {numero1 / numero2}");

                    break;
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            #endregion
        }
    }
}