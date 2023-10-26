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
                try
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
                        case 2:
                            ClsEmpleados.Consultar();
                            break;
                        case 3: 
                            ClsEmpleados.Modificar();
                            break;
                        case 4:
                            ClsEmpleados.Borrar();
                            break;
                        case 5:
                            ClsEmpleados.Inicializar();
                            break;
                        case 6:
                            subMenu();
                            break;
                    }
                }
                catch {Console.Clear(); Console.WriteLine("\nIngrese una opción correcta\n"); }
            }
            while (again);
        }

        public static void subMenu()
        {
            do
            {
                Console.WriteLine("\n---REPORTES---\n");
                Console.WriteLine("1. Consultar Empleado\n2. Lista General Empleados\n3. Promedio de los salarios\n" +
                      "4. Salario Mínimo y Máximo\n0. Atrás");
                Console.Write("\nIngrese una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 0:
                        menu();
                        break;
                    case 1:
                        ClsEmpleados.reporteEmpleado();
                        break; 
                    case 2:
                        ClsEmpleados.reporteGeneral();
                        break;
                    case 3:
                        ClsEmpleados.promedio();
                        break;
                    case 4:
                        ClsEmpleados.MaxMin();
                        break;
                }
            }
            while (again);
        }
    }
}
