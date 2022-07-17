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

namespace EXPLICACION_4
{
    class Datos
    {
        public string fruitName;     //CREAR LAS VARIABLES DE CAMPO
        public double fruitPrice;
        public Datos()     //CONSTRUCTOR
        { }

        public Datos(string name,double price)     //CONSTRUCTOR USADO PARA INICIAIZAR VALORES DE LOS CAMPOS
        {
            fruitName = name;     //fruitName= HACE REFERENCIA A LA VARIABE DE CAMPO //name= HACE REFERENCIA AL ARGUMENTO
            fruitPrice = price;
        }

        public override string ToString()
        {
            // return "Fruit" + fruitName + "Price" + fruitPrice;     //FORMA 1
            return $"Fruit: {fruitName} \nPrice: {fruitPrice}";     //FORMA 2 //INTERPOLACION = $"" 
        }
    }
}
