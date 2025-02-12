using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangulo : Poligono
    {
        private double b;
        private double a;

        public Rectangulo(double b, double a) : base(4)
        {
            this.b = b;
            this.a = a;
        }

        public override double Area()
        {
            return this.b * this.a;
        }

        public override double Perimetro()
        {
            return 2 * (this.b + this.a);
        }

        public override string ToString()
        {
            return $"Soy un rectángulo de base: {this.b} y altura: {this.a}. Con perímetro: {Perimetro()}. Area: {Area()}";
        }
    }
}
