using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPLICACION_2
{
    class Mainprogram
    {
        public static void Main(string[]args)
        {
            //CREAR E INSTANCIAR OBJRTO DE TIPO DATOS
            Datos myData = new Datos();     //();USANDO CONSTRUCTOR VACIO //CREAR UNA INSTANCIA
            myData.Nombre = "Jhon Sebastian";
            myData.Apellido = "Rodriguez Bohada";     //SE INSTANCIA
            Console.WriteLine(myData.Nombre,myData.Apellido);     //Console= CLASE //WriteLine= METODO
        }
    }
}
