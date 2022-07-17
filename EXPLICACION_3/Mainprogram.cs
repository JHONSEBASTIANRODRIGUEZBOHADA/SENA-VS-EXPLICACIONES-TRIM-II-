using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPLICACION_3
{
    class Mainprogram
    {
        public static void Main(string[]args)
        {
            //CREAR E INSTANCIAR OBJETO TIPO DATOS
            Datos myFruit = new Datos();     //();USANDO CONSTRUCTOR VACIO //CREAR UNA INSTANCIA
            myFruit.Name = "Pineapple";     //SE INSTANCIA
            myFruit.Price = 5.500;
            Console.WriteLine(myFruit.Name, myFruit.Price);     //Console= CLASE //WriteLine= METODO
        }
    }
}
