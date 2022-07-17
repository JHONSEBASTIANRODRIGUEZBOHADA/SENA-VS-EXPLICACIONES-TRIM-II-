using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
PILARES DE LA OOP
-Herencia
-Encapsulacion
-Polimorfismo
-Abstraccion
-----------------------------------------------------------------------------------------------------------------------------
ESTRUCTURA DE C#
-spacename= para organizar los archivos
-class= la clase con su nombre
-metodos
-----------------------------------------------------------------------------------------------------------------------------
CLASE
-Representacion / Plano para un objeto

OBJETO
-Instancia para una clase / Nombre del objeto

EJEMPLO

car Mycar = new car();     //como se dice= se crea e instancia un objeto de tipo car //== hace referencia a los atributos 

-car= clase //de que tipo es (car)
-Mycar= objeto //nombre de la clase
-new= crea una instancia /para poder usar los objetos de una clase 
-car Mycar = new car();= esto es un objeto de tipo car
-----------------------------------------------------------------------------------------------------------------------------
METODOS
-Lo que es capas de hacer
-Ejecuta comportamientos
-Todo metodo tiene que tener parentecis

-Cuando se define las variables en un metodo se le dice parametros
-Cuando se llama las variables a un metodo se le dice argumentos
-----------------------------------------------------------------------------------------------------------------------------
TENER EN CUENTA
-METODOS= PUBLICOS
-CAMPOS= PRIVADOS
-----------------------------------------------------------------------------------------------------------------------------
 */

namespace EXPLICACION_5     //SE USA PARA ORGANIZAR ARCHIVOS
{
    class Mainprogram     //NOMBRE DE LA CLASE DE TIPO CLASS
    {
        public static void Main(string[]aargs)     //void= NO RETORNA NINGUN VALOR
        {
            //CREAR E INSTANCIAR OBJETO DATOS
            Datos myData = new Datos("pineapple",123.25);      //CREAR UNA INSTANCIA
            Console.WriteLine(myData.fruitName, myData.fruitPrice);     //Console= CLASE //WriteLine= METODO
        }
    }
}
