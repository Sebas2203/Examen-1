﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Recursos_Humanos
{
    internal class ClsEmpleados
    {
        //atributos
        static int cantidad = 5;
        static byte indice = 0;
        static byte posicion = 1;

        private static int[] cedula = new int[cantidad];
        private static string[] nombre = new string[cantidad];
        private static string[] direccion = new string[cantidad];
        private static int[] telefono = new int[cantidad];
        private static float[] salario = new float[cantidad];

        //metodos menu
        public static void Agregar()
        {
            char respuesta = ' ';
            do
            {
                try
                {
                    Console.WriteLine($"\n---Empleado {posicion}--\n");
                    Console.Write("Cédula: ");
                    cedula[indice] = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    nombre[indice] = Console.ReadLine();
                    Console.Write("Dirección: ");
                    direccion[indice] = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    telefono[indice] = int.Parse(Console.ReadLine());
                    Console.Write("Salario: ");
                    salario[indice] = float.Parse(Console.ReadLine());
                    indice++;
                    posicion++;
                    Console.WriteLine("¿Desea ingresar otro Empleado? S/N");
                    respuesta = char.Parse(Console.ReadLine().ToUpper());
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError al ingresar empleado\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (!respuesta.Equals('N') && posicion <= cantidad);
            Console.ReadLine();
            Console.Clear();
        }

        public static void Consultar()
        {
            Console.WriteLine("\n---Reporte Empleados---\n");
            for (int i = 0; i < posicion - 1; i++)
            {
                Console.WriteLine($"Cédula: {cedula[i]}\nNombre: {nombre[i]}\nTeléfono: {telefono[i]}\n" +
                    $"Dirección: {direccion[i]}\nSalario: {salario[i]}");
                Console.WriteLine("------------");
            }
            Console.WriteLine("\n---Fin Reporte Empleados---\n");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Borrar()
        {
            Console.WriteLine("Digite el número de cédula que se desea eliminar");
            int borrarEmpleado = int.Parse(Console.ReadLine());
            bool existe = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (borrarEmpleado.Equals(cedula[i]))
                {
                    existe = true;

                    cedula[i] = 0;
                    nombre[i] = " ";
                    direccion[i] = " ";
                    telefono[i] = 0;
                    salario[i] = 0;
                }
            }
            if (existe.Equals(false))
            {
                Console.WriteLine($"No se encontró el empleado con el número de cédula {borrarEmpleado}");
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void Modificar()
        {
            Console.WriteLine("Digite el número de cédula que se desea modificar");
            int modificarEmpleado = int.Parse(Console.ReadLine());
            bool existe = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (modificarEmpleado.Equals(cedula[i]))
                {
                    existe = true;

                    Console.Write("Nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Dirección: ");
                    direccion[i] = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    telefono[i] = int.Parse(Console.ReadLine());
                    Console.Write("Salario: ");
                    salario[i] = float.Parse(Console.ReadLine());
                }
            }
            if (existe.Equals(false))
            {
                Console.WriteLine($"No se encontró el empleado con el número de cédula {modificarEmpleado}");
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void Inicializar()
        {
            cedula = Enumerable.Repeat(0, cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();

            posicion = 1;
            indice = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nArrelgos Inicializados\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
        }

        //metodos de submenu
        public static void reporteEmpleado()
        {
            bool existe = false;

            Console.Write("Introduzca la Cédula: ");
            int consulta = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                if (consulta.Equals(cedula[i]))
                {
                    existe = true;
                    Console.WriteLine("------------");
                    Console.WriteLine($"Cédula: {cedula[i]}\nNombre: {nombre[i]}\nTeléfono: {telefono[i]}\n" +
                    $"Dirección: {direccion[i]}\nSalario: {salario[i]}");
                    Console.WriteLine("------------");
                    break;
                }

            }
            if (existe.Equals(false))
            {
                Console.WriteLine($"No se encontró el empleado con el número de cédula {consulta}");
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void reporteGeneral()
        {
            Array.Sort(nombre);

            Console.WriteLine("\n---Empleados ordenados---\n");
            foreach (string i in nombre)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void promedio()
        {
            Console.WriteLine($"\nEl promedio de salarios es de: { salario.Average()}\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MaxMin()
        {
            Console.WriteLine($"\nEl Salario mínimo es: {salario.Min()}");
            Console.WriteLine($"El Salario máximo es : {salario.Max()}\n");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
