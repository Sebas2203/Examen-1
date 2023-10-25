using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Recursos_Humanos
{
    internal class ClsMenu
    {
        ClsEmpleados empleados = new ClsEmpleados();
        static bool again = true;
        static int opcion = 0;
        public static void menu() 
        {
            do
            {
                Console.WriteLine("1. Agregar Empleados\n2. Consultar Empleados\n3. Modificar Empleados\n" +
                      "4. Borrar Empleados\n5. Inicializar Arrelgos\n6. Reportes\n0. Salir");
                Console.Write("\nIngrese una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 0:
                        again = false;
                        Console.WriteLine("\n¡Hasta la próxima!\n\nEnter para salir.");
                        break;
                    case 1:
                        ClsEmpleados.Agregar();
                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5:
                        ClsEmpleados.Inicializar();
                        break;
                    case 6:
                        subMenu();
                        break;
                }
            }
            while (again);
        }

        public static void subMenu()
        {
            do
            {
                Console.WriteLine("1. Consultar Empleado\n2. Reporte General Empleados\n3. Calcular y mostrar el promedio de los salarios Empleados\n" +
                      "4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados\n0. Atrás");
                Console.Write("\nIngrese una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 0:
                        again = false;
                        break;
                    case 1: break; 
                    case 2:
                        ClsEmpleados.reporteGeneral();
                        break;
                }
            }
            while (again);
        }
    }
}
