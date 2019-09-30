using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1

            Console.WriteLine("EJERCICIO 1");
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }

            #endregion

            #region Ejercicio 2

            Console.WriteLine("EJERCICIO 2");
            n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n += 2;
            }

            #endregion

            #region Ejercicio 3

            Console.WriteLine("EJERCICIO 3");
            n = 10;
            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }

            #endregion

            #region Ejercicio 4

            Console.WriteLine("EJERCICIO 4");
            n = 1;
            while (n <= 10)
            {
                if (n != 2 && n != 5 && n != 9)
                {
                    Console.WriteLine(n);
                }

                n++;
            }

            #endregion

            #region Ejercicio 5

            Console.WriteLine("EJERCICIO 5");
            n = 1;
            while (n <= 30)
            {
                if (n < 10 || n > 20)
                {
                    Console.WriteLine(n);
                }

                n++;
            }

            #endregion

            #region Ejercicio 6

            Console.WriteLine("EJERCICIO 6");
            n = 1;
            int suma = 0;
            while (n <= 10)
            {
                suma += n;
                n++;
            }

            Console.WriteLine($"La suma del 1 al 10 es {suma}");

            #endregion

            #region Ejercicio 7

            Console.WriteLine("EJERCICIO 7");
            n = 1;
            suma = 0;
            while (n <= 25)
            {
                if (n % 2 == 0)
                {
                    suma += n;
                }

                n++;
            }

            Console.WriteLine($"La suma de pares del 1 al 25 es {suma}");

            #endregion

            #region Ejercicio 8

            Console.WriteLine("EJERCICIO 8");
            n = -10;
            int productoria = 1;

            while (n <= 10)
            {
                if (n % 2 != 0)
                {
                    productoria *= n;
                }

                n++;
            }

            Console.WriteLine($"La productoria es  {productoria}");

            #endregion

            #region Ejercicio 1 - FOR

            Console.WriteLine("EJERCICIO 1 - FOR");
            for (n = 1; n <= 10; n++)
            {
                Console.WriteLine(n);
            }

            #endregion

            #region Ejercicio 2 - FOR

            Console.WriteLine("EJERCICIO 2 - FOR");
            for (n = 1; n <= 10; n += 2)
            {
                Console.WriteLine(n);
            }

            #endregion

            #region Ejercicio 3 - FOR

            Console.WriteLine("EJERCICIO 3 - FOR");
            for (n = 10; n > 0; n--)
            {
                Console.WriteLine(n);
            }

            #endregion

            #region Ejercicio 4 - FOR

            Console.WriteLine("EJERCICIO 4 - FOR");
            suma = 0;
            for (n = 1; n <= 10; n++)
            {
                if (n % 2 != 0)
                {
                    suma += n;
                }
            }

            Console.WriteLine($"La suma de los impares de 1 al 10 es: {suma}");

            #endregion

            #region Ejercicio 5 - FOR

            Console.WriteLine("EJERCICIO 5 - FOR");
            int producto = 1;
            suma = 0;
            for (n = 1; n <= 5; n++)
            {
                producto *= n;
                suma += n;
            }

            Console.WriteLine($"Resultado resta productoria y sumatoria: {producto - suma}");

            #endregion

            #region Ejercicio 6 - FOR

            Console.WriteLine("EJERCICIO 6 - FOR");
            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("@");
            }

            #endregion

            #region Ejercicio 7 - FOR

            Console.WriteLine("EJERCICIO 7 - FOR");
            for (n = 1; n <= 5; n++)
            {
                Console.WriteLine(n % 2 != 0 ? "@" : "@@");
            }

            #endregion

            #region Ejercicio 8 - FOR

            Console.WriteLine("EJERCICIO 8 - FOR");
            string cadena = "";
            for (n = 1; n <= 5; n++)
            {
                cadena += "@";
                Console.WriteLine(cadena);
            }

            #endregion

            #region Ejercicio 9 - FOR

            Console.WriteLine("EJERCICIO 9 - FOR");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }

            #endregion

            #region Ejercicio 10 - FOR

            Console.WriteLine("EJERCICIO 10 - FOR");
            cadena = "";
            for (n = 1; n <= 5; n++)
            {
                cadena += "@";
                Console.WriteLine(cadena);
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }

            #endregion

            #region Ejercicio 11 - FOR

            Console.WriteLine("EJERCICIO 11 - FOR");
            int lineas = 5;
            int mitad = lineas - 2;
            for (int i = 0; i < lineas; i += 2)
            {
                for (int j = lineas; j > i; j--)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }

            for (int i = mitad; i <= lineas; i += 2)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }

            #endregion
        }
    }
}