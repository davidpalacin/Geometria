using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma forma = new Forma();
            Console.WriteLine(forma.ToString());

            Rectangulo rectangulo = new Rectangulo(10, 20);
            Console.WriteLine(rectangulo.ToString());

            Cuadrado cuadrado = new Cuadrado(15);
            Console.WriteLine(cuadrado.ToString());




        }
    }
}
