using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Impresion_de_Estructura
{
    class Program
    {
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("Empleado: {0}, Nombre :{1},Eda:{2}, Sueldo {3}", id, nombre, edad, sueldo);
                return cadena.ToString();
            }

        }
        static void Main(string[] args)
        {

            //se crea una variable de tipo  empleado
            empleado uno;
            //asignar valoores
            uno.nombre = "Khris";
            uno.edad = 19;
            uno.id = 1024;
            uno.sueldo = 4.00;
            Console.WriteLine(uno);
            Console.ReadKey();
            Console.WriteLine("{0}        {1}         {2}         {3}", uno.nombre, uno.edad, uno.id, uno.sueldo);
            //llenar interativamente
            empleado prueba;
            Console.WriteLine("Ingrese nombre del trabajador");
            prueba.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Edad del empleado");
            prueba.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ID del emnpleado");
            prueba.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Sueldodel empleado");
            prueba.sueldo = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            //mostrar Datos
            Console.WriteLine("{0}        {1}         {2}         {3}", prueba.nombre, prueba.edad, prueba.id, prueba.sueldo);
            Console.WriteLine(prueba.ToString());
            Console.ReadKey();
        }
    }
}
