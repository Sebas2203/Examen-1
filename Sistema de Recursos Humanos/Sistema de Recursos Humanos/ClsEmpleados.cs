using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Recursos_Humanos
{
    internal class ClsEmpleados
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public float salario { get; set; }

        public ClsEmpleados(int cedula, string nombre, string direccion, int telefono, float salario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.salario = salario;
        }

        public static void Agregar()
        {

        }
    }
}
