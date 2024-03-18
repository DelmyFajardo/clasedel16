using practicadel16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoDemo0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // practica de progra orientada a objetos
            // creo objeto de la clase y a esto se le llamo un objeto o instancia
            //Estado son los valores de las propiedades de un objeto osea cuando se le asignan valores
            Animal foca = new Animal( "foca", 0.50, 1.34, "hembra"); // todo los metodos tienen un metodo construcctor con el mismo nombre de la clase 
            // la palabra new va porque crea un metodo construcctor  y este construcctor nos ayuda a ahorrar codigo
            // la edad no va en el constructor ya que no siempre va a tener una misma edad  
           // foca.nombre = " foca";
          //  foca.altura = 0.50;
           // foca.peso = 1.34;
           // foca.sexo = "hembra" ;
           // foca.edad = 2;
            foca.Nombre = "otro nombre";



            Console.WriteLine(" mi animal es: "+ foca);
            //cuando le pido a la clase animal que  haga una accion en el programa pincipla  a eso se le llama mensaje 
            //metodos de acceso son getters o setter 
            foca.Comer(); 
            Console.ReadKey();


             
             
        }
    }
}
