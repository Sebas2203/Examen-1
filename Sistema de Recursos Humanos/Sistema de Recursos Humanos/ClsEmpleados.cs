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
        private int[] cedula = new int[cantidad];
        private string[] nombre = new string[cantidad];
        private string[] direccion = new string[cantidad];
        private int[] telefono = new int[cantidad];
        private float[] salario = new float[cantidad];

        //constructor
        public ClsEmpleados(int[] cedula, string[] nombre, string[] direccion, int[] telefono, float[] salario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.salario = salario;
        }


        //metodos
        public void Inicializar()
        {
            cedula = Enumerable.Repeat(0, cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();
            Console.WriteLine("Arrelgos Inicializados");
        }
        public static void Agregar()
        {
            //2:00:00
        }
    }
}
