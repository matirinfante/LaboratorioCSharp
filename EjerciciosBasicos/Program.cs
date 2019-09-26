using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionUsuario;
            do
            {
                opcionUsuario = mostrarOpciones();
                resolverOpcion(opcionUsuario);
            } while (opcionUsuario != 0);
        }

        /// <summary>
        /// Muestra las opciones al usuario. Si éste no ingresa un número, vuelve a preguntar.
        /// </summary>
        /// <returns>Un entero representando la opcion elegida por el usuario</returns>
        static int mostrarOpciones()
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("Ejercicios Basicos -- Bonus Edition");
                Console.WriteLine("Seleccione que ejercicio desea ejecutar (1-5): ");
                Console.WriteLine("Seleccione '0' para salir.");
            } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 5);

            return opcion;
        }

        /// <summary>
        /// Resuelve la opción seleccionada por el usuario.
        /// </summary>
        /// <param name="opcionUsuario">Entero que representa la opción elegida por el usuario</param>
        static void resolverOpcion(int opcionUsuario)
        {
            switch (opcionUsuario)
            {
                case 1:
                    ejercicioUno();
                    break;
                case 2:
                    ejercicioDos();
                    break;
                case 3:
                    ejercicioTres();
                    break;
                case 4:
                    ejercicioCuatro();
                    break;
                case 5:
                    ejercicioCinco();
                    break;
                case 0: break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Dados n1=5 , n2=10 y n3=20. Informar:
        /// a) n1 + n2
        /// b) n3 - n1
        /// c) n1 * n3
        /// d) n3 / n2
        /// </summary>
        static void ejercicioUno()
        {
            int n1 = 5, n2 = 10, n3 = 20;

            Console.WriteLine("Ejercicio UNO\n");
            Console.WriteLine($"n1 + n2 = {n1 + n2}");
            Console.WriteLine($"n3 - n1 = {n3 - n2}");
            Console.WriteLine($"n1 * n3 = {n1 * n3}");
            Console.WriteLine($"n3 / n2 = {n3 / n2}");
        }

        /// <summary>
        /// Dados n1=10, n2=20 y n3=30. Informar:
        /// a) El total
        /// b) El promedio
        /// c) El resto entre n2 y n1
        /// </summary>
        static void ejercicioDos()
        {
            int n1 = 10, n2 = 20, n3 = 30, sumaTotal = n1 + n2 + n3;
            double promedio = sumaTotal / 3;
            int restoDivision = n2 % n1;

            Console.WriteLine("Ejercicio DOS\n");
            Console.WriteLine($"Suma total de los números: {sumaTotal}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Resto de la division entre n2 y n1: {restoDivision}");
        }

        /// <summary>
        /// Dados n1=true, n2=false y n3=true. Informar:
        /// a) n1 ^ n2
        /// b) (n1 & !n2) | n3
        /// c) (n1 | n2) & !n3
        /// </summary>
        static void ejercicioTres()
        {
            bool n1 = true, n2 = false, n3 = true;

            Console.WriteLine("Ejercicio TRES\n");
            Console.WriteLine($"n1 ^ n2 = {n1 ^ n2}");
            Console.WriteLine($"(n1 & !n2) | n3 = {(n1 & !n2) | n3}");
            Console.WriteLine($"(n1 | n2) & !n3 = {(n1 | n2) & !n3}");
        }

        /// <summary>
        /// Declarar dos variables n1=5 y n2=10.
        /// Utilizando concatenación entre las variables y los literales, mostrar en pantalla la siguiente expresión:
        /// n1 es igual a 5, n2 es igual a 10 y n1 más n2 es igual a 15.
        /// </summary>
        static void ejercicioCuatro()
        {
            int n1 = 5, n2 = 10;
            //NO queria usar esto
            Console.WriteLine("Ejercicio CUATRO\n");
            Console.WriteLine("n1 es igual a " + n1 + ", n2 es igual a " + n2 + " y n1 mas n2 es igual a " + (n1 + n2));
            Console.WriteLine("o lo mismo pero usando interpolación...");
            Console.WriteLine($"n1 es igual a {n1}, n2 es igual a {n2} y n1 mas n2 es igual a {n1 + n2}");
        }

        /// <summary>
        /// Haciendo uso de la constante IVA=21, calcular el precio con IVA de los siguientes productos e informar:
        /// a) remera: 59.90$
        /// b) pantalón: 99.90$
        /// c) campera: 149.90$
        /// </summary>
        static void ejercicioCinco()
        {
            const double IVA = 21;
            const double IVACALC = 1.21;
            double remera = 59.9, pantalon = 99.9, campera = 149.9;

            Console.WriteLine("Ejercicio CINCO\n");
            Console.WriteLine($"Precio final remera: {remera + remera * IVA / 100}");
            Console.WriteLine($"Precio final pantalon: {pantalon * IVACALC}"); //Mejorcito
            Console.WriteLine($"Precio final campera: {campera + campera * IVA / 100}");
        }
    }
}