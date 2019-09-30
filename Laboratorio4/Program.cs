﻿using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1

            Console.WriteLine("EJERCICIO 1");
            int[] arreglo = {10, 20, 5, 15, 30, 20};
            int n, total = 0, maximo = -1, contadorApariciones = 0;

            for (n = 0; n < arreglo.Length; n++)
            {
                if (n % 2 != 0) Console.WriteLine($"Posición  {n}\tValor:{arreglo[n]}");
                if (arreglo[n] > maximo) maximo = arreglo[n];
                if (arreglo[n] == 20) contadorApariciones++;
                total += arreglo[n];
            }

            Console.WriteLine($"El numero mayor es: {maximo}");
            Console.WriteLine($"El total es: {total}");
            Console.WriteLine($"El 20 apareció: {contadorApariciones} veces");

            #endregion

            #region Ejercicio 2 y 3 + Dictionary

            Console.WriteLine("EJERCICIO 2 + 3");
            double[] arregloInflacion = {0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9};
            int posicionMin = 0, posicionMax = 0;
            double valorTotal = 0, valorMax = arregloInflacion[0], valorMin = arregloInflacion[0];

            for (int i = 0; i < arregloInflacion.Length; i++)
            {
                valorTotal += arregloInflacion[i];

                if (arregloInflacion[i] > valorMax)
                {
                    valorMax = arregloInflacion[i];
                    posicionMax = i + 1;
                }
                else if (arregloInflacion[i] < valorMin)
                {
                    valorMin = arregloInflacion[i];
                    posicionMin = i + 1;
                }
            }

            var meses = new Dictionary<int, string>();
            meses.Add(1, "Enero");
            meses.Add(2, "Febrero");
            meses.Add(3, "Marzo");
            meses.Add(4, "Abril");
            meses.Add(5, "Mayo");
            meses.Add(6, "Junio");
            meses.Add(7, "Julio");
            meses.Add(8, "Agosto");
            meses.Add(9, "Septiembre");
            meses.Add(10, "Octubre");
            meses.Add(11, "Noviembre");
            meses.Add(12, "Diciembre");

            Console.WriteLine($"Promedio: {valorTotal / 12}");
            Console.WriteLine($"Mínima inflación: {valorMin} mes: {meses[posicionMin]}");
            Console.WriteLine($"Máxima inflación: {valorMax} mes: {meses[posicionMax]}");

            #endregion

            #region Ejercicio 4

            Console.WriteLine("EJERCICIO 4");
            double[] facturacion = new double [6];
            valorTotal = 0;
            valorMax = 0;
            valorMin = facturacion[0];

            for (int i = 0; i < facturacion.Length; i++)
            {
                Console.WriteLine($"Ingrese facturación {i + 1}: ");
                Double.TryParse(Console.ReadLine(), out facturacion[i]);
            }

            foreach (var valorFacturacion in facturacion)
            {
                valorTotal += valorFacturacion;
                if (valorFacturacion > valorMax)
                {
                    valorMax = valorFacturacion;
                }
                else if (valorFacturacion < valorMin)
                {
                    valorMin = valorFacturacion;
                }
            }

            Console.WriteLine($"Facturación total: {valorTotal}");
            Console.WriteLine($"Promedio: {valorTotal / 12}");
            Console.WriteLine($"Mínima facturación: {valorMin}");
            Console.WriteLine($"Máxima facturación: {valorMax}");

            #endregion

            #region Ejercicio 5

            Console.WriteLine("EJERCICIO 5");
            int[] arregloOrigen = {2, 10, -4, 8, 0};
            int[] arregloDestino = new int [arregloOrigen.Length];

            for (int i = 0; i < arregloOrigen.Length; i++)
            {
                arregloDestino[i] = arregloOrigen[i];
                Console.WriteLine($"Índice: {i} valor: {arregloDestino[i]}");
            }

            #endregion

            #region Ejercicio 6 Bonus

            Console.WriteLine("EJERCICIO 6 BONUS");
            arregloDestino = new int [arregloOrigen.Length];

            for (int i = arregloOrigen.Length - 1; i > 0; i--)
            {
                arregloDestino[arregloOrigen.Length - i - 1] = arregloOrigen[i];
            }

            for (int i = 0; i < arregloDestino.Length; i++)
            {
                Console.WriteLine($"Índice: {i} valor: {arregloDestino[i]}");
            }

            #endregion
        }
    }
}