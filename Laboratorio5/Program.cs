using System;

namespace Laboratorio5
{
    class Program
    {
        public static void Main(String[] args)
        {
            int opcion;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "INTERFAZ PRINCIPAL";
            Console.WriteLine("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
            }

            Console.WriteLine("Saliendo...");
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Uso de un procedimiento";
            int num;
            Console.WriteLine("Ingrese un numero entero positivo:");
            num = int.Parse(Console.ReadLine());
            esPar(num);
            Console.WriteLine();
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }

        static void esPar(int a)
        {
            Console.WriteLine(a % 2 == 0 ? "Es par" : "Es impar");
        }

        static void Ejercicio2()
        {
            Console.Title = "Trabajando con Procedimientos";
            Double res, n1, n2;
            Console.WriteLine("Ingrese primer número");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número");
            n2 = Double.Parse(Console.ReadLine());
            res = suma(n1, n2);
            Console.WriteLine($"El resultado de la suma es: {res}");
            Console.ReadKey();
            Console.Clear();
            res = resta(n1, n2);
            Console.WriteLine($"El resultado de la resta es: {res}");
            Console.ReadKey();
        }

        static double suma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double resta(double n1, double n2)
        {
            return n1 - n2;
        }

        static void Ejercicio3()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "Ejemplo4 de Procedimientos en un menú";
            Int32 num1, num2;
            int opcion;
            Console.WriteLine("\n MENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
            Console.WriteLine("\n");

            Console.Write("\tIngresar el primer número: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("\tIngresar el segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\n MENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n ===============================================");
            Console.WriteLine("\n");
            Console.WriteLine("\t1) Mayor de los 2");
            Console.WriteLine("\t2) Multiplo");
            Console.WriteLine("\t3) Potencia");
            Console.WriteLine("\n ===============================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.Write("\tIngresar la opción deseada [1..3]: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1:
                    mayor(num1, num2);
                    break;
                case 2:
                    multiplo(num1, num2);
                    break;
                case 3:
                    potencia(num1, num2);
                    break;
                default:
                    Console.WriteLine("\tSe ha equivocado de opcion, solo acepta[1..3]");
                    break;
            }

            Console.WriteLine("\n");
            Console.WriteLine("\t-->Fin del programa");
            Console.ReadKey();
        }

        static void mayor(Int32 a, Int32 b)
        {
            if (a > b)
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", b, a);
            }
        }

        static void multiplo(Int32 a, Int32 b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("\tEl numero {0} es multiplo de {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} no es multiplo de {1} ", b, a);
            }
        }

        static void potencia(Int32 a, Int32 b)
        {
            Double s;
            s = Math.Pow(a, b);
            Console.WriteLine("\tEl numero {0} a la potencia de {1} es: {2}", a, b, s);
        }
    }
}