using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Recursos_Humanos
{
    internal class ClsEmpleados
    {
        //atributos
        static int cantidad = 3;
        static byte indice = 0;
        static byte posicion = 1;

        private static int[] cedula = new int[cantidad];
        private static string[] nombre = new string[cantidad];
        private static string[] direccion = new string[cantidad];
        private static int[] telefono = new int[cantidad];
        private static float[] salario = new float[cantidad];


        //metodos
        public static void Inicializar()
        {
            cedula = Enumerable.Repeat(0, cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nArrelgos Inicializados\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
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
            while (!respuesta.Equals('N'));
        }

        public static void reporteGeneral()
        {
            Console.WriteLine("\n---Reporte Empleados---\n");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Cédula: {cedula[i]}\nNombre: {nombre[i]}\nTeléfono: {telefono[i]}\n" +
                    $"Dirección: {direccion[i]}\nSalario: {salario[i]}");
                Console.WriteLine("------------");
            }
            Console.WriteLine("\n---Fin Reporte Empleados---\n");

            //2:26:00
        }
    }
}
