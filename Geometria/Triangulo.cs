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

        public Triangulo(double ladoA, double ladoB, double ladoC) : base(3)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public override double Area()
        {
            // Calcular el semiperímetro
            double s = (LadoA + LadoB + LadoC) / 2;

            // Calcular el área
            return  Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public override double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override string ToString()
        {
            return $"Soy un triángulo. Mis lados miden: {LadoA}, {LadoB} y {LadoC}. Mi área es: {Area()} y mi perímetro es {Perimetro()}";
        }
    }
}
