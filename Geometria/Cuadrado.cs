using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Cuadrado : Rectangulo
    {
        public double Lados { get; set; }

        public Cuadrado(double lados) : base(lados, lados)
        {
            Lados = lados;
        }

        public override string ToString()
        {
            return $"Soy un cuadrado con lados de: {Lados}. Con perímetro: {Perimetro()}. Area: {Area()}";
        }
    }
}
