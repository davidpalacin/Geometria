using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangulo : Forma
    {
        // debe tener una base y una altura, además de un método para calcular el área y otro para calcular el perimetro
        private double b;
        private double a;

        public Rectangulo(double b, double a)
        {
            this.b = b;
            this.a = a;
        }

        public double Area()
        {
            return this.b * this.a;
        }

        public double Perimetro()
        {
            return 2 * (this.b + this.a);
        }
    }
}
