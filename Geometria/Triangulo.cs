using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Triangulo : Poligono
    {
        // Propiedades específicas del triángulo
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double B { get; set; } // Base
        public double A { get; set; } // Altura



        public Triangulo(double ladoA, double ladoB, double ladoC, double b, double a) : base(3)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            B = b;
            A = a;
        }

        public Triangulo() : base(3) // Constructor por defecto
        {
            LadoA = 4;
            LadoB = 4;
            LadoC = 4;
            B = 10;
            A = 5;
        }

        public override double Area()
        {
            return (B * A) / 2;
        }
    }
}
