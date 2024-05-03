using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6deabril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "Juan";
            int Edad = 30;
            int salario = 5000;
            string Especialidad = "Ingeniero Civil";
            //crear un objeto ingeniero
            Ingeniero ingeniero = new Ingeniero(Nombre, Edad, salario, Especialidad);
            //mostrar informacion del ingeniro
            Console.WriteLine("Informacion del ingeniro");
            ingeniero.MostrarInformacion();
            ingeniero.MostrarEspecialidad();

            Console.WriteLine();

            Nombre = "maria";
            Edad = 20;
            salario = 45000;
            string TipoDiseno = "Diseño Grafico";
            //crear un objeto diseñador
            Disenador disenador = new Disenador(Nombre, Edad, salario, TipoDiseno);
            //mostrar informacion del diseñador 
            Console.WriteLine("Informacion del Diseñador");
            disenador.MostrarInformacion();
            disenador.MostrarTipoDeDiseno();

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
