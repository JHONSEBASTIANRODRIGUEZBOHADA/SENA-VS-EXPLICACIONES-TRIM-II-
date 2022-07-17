using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
CONSTRUCTOR
-Metodo especial
-Usado para iniciaizar objetos
*/

namespace EXPLICACION_5
{
    class Datos
    {
        public string fruitName;     //CREAR LAS VARIABLES DE CAMPO
        public double fruitPrice;

        public Datos() { }     //CONSTRUCTOR VACIO
        public Datos(string name,double price)     //CONSTRUCTOR USADO PARA INICIALIZAR VALORES DE LOS CAMPOS
        {
            this.fruitName = name;     //fruitName= HACE REFERENCIA A LA VARIABLE DE CAMPO //name= HACE REFERENCIA AL ARGUMENTO
            this.fruitPrice=price;     //this= HACE IGUAL A LA VARIABLE DE CAMPO Y EL ARGUMENTO
        }

        public override string ToString()
        {
            //return "Fruta" + fruitName + "Price" + fruitPrice;
            return $"Fruit: {fruitName} \nPrice: {fruitPrice}";     //INTERPOLACION:$""
        }
    }
}
