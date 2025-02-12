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

            Rectangulo rectangulo = new Rectangulo(15, 15);
            Console.WriteLine(rectangulo.ToString());

            Triangulo tri = new Triangulo();
            Console.WriteLine(tri.ToString());

            Cuadrado cuadrado = new Cuadrado(15);
            Console.WriteLine(cuadrado.ToString());

            Elipse elipse = new Elipse(10, 20);
            Console.WriteLine(elipse.ToString());

            Circulo circulo = new Circulo(10);
            Console.WriteLine(circulo.ToString());

            List<Forma> formas = new List<Forma>{circulo, cuadrado};

            Diagrama dia = new Diagrama(formas);

            Console.WriteLine(dia.ToString());
        }
    }
}
