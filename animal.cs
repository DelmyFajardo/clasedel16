using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicadel16
{
    internal class Animal // esta clse solo puede ser usa en el main space
                          //metodos 
    {
        private string nombre;
        public string Nombre {
            get { return nombre; }
            set {  nombre = value; }
        }
        private double altura;
        private double peso;
        private string sexo;
        public  int Edad { // permite que mi elemento tenga un encapsulado desde el principio 
            get;set;
        }

        public string GetNombre()
        { return nombre; }

      // toadaas las clases tienen un metodo que se llama ToString()

        public string GetPeso ( ) 
        { return sexo; }
        public void SetPeso() 
        { return ; }
        // creo metodo de comer cuando hago un metodo en este caso uso la palabra public  acompañado de void 
        //pilares bases de la proga : encampsulamiento el cual se base enn proteger las propiedades de un objeto,
        //como protejo el atributo nombre, altura,peso,sexo  eso se hace con la palabra private 
        public Animal( string nombre, double altura, double peso, string sexo)
        {//la palabra this sirve para diferenciar el nombre de clase con otra clase 
            this .nombre = nombre;
            this .altura = altura;
            this .peso = peso;
            this .sexo = sexo;
         } 
        public void Comer()
        {
            Console.WriteLine( "la " + nombre + "come pescado"); 
        }
         //permite devolver un string los atributos de una clase 
        public override string ToString()
        {
            return "nombre" + nombre + "altura" + altura + " peso"+ peso + "edad" + Edad  ;
        }



    }
}
