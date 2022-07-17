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

namespace EXPLICACION_6
{
    class Datos
    {
        private string fruitName;     //CREAR LAS VARIABLES DE CAMPO
        private double fruitPrice;

        public Datos() { }     //CONSTRUCTOR VACIO

        public Datos(string name,double price)     //CONSTRUCTOR USADO PARA INICIALIZAR VALORES DE LOS CAMPOS     
        {
            this.fruitName = name;     //fruitName= HACE REFERENCIA A LA VARIABLE DE CAMPO //name= HACE REFERENCIA AL ARGUMENTO
            this.fruitPrice = price;     //this= HACE IGUAL A LA VARIABLE DE CAMPO Y EL PARAMETRO
        }

        public string GetFruitName()
        {
            return fruitName;
        }

        public void SetFruitName(string fruitname)     //this= HACE IGUAL A LA VARIABLE DE CAMPO Y EL PARAMETRO
        {
            this.fruitName = fruitname;
        }

        public double GetFruitPrice()
        {
            return fruitPrice;
        }

        public void SetFruitPrice(double fruitPrice)     //this= HACE IGUAL A LA VARIABLE DE CAMPO Y EL PARAMETRO
        {
            this.fruitPrice = fruitPrice;
        }

        public override string ToString()
        {
            //return "Fruit:" + fruitName + "´Price:" + fruitPrice;
            return $"Fruit: {fruitName} \nPrice: {fruitPrice}";     //INTERPOLACION= $""
        }
    }
}
//TENGO QUE REVISAR POR QUE HAY ERRORES