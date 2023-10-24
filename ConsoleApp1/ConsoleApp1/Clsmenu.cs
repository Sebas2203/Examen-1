using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clsmenu
    {
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
                        ClsEmpleado.Agregar(); 
                        break; 
                    case 2: break; 
                    case 3: break; 
                    case 4: break; 
                    case 5: break; 
                    case 6: break;
                }
            }
            while (again);
        }
    }
}
