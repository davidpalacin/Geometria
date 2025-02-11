using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Cuadrado : Rectangulo
    {
        private double lados;
        public Cuadrado(double lados) : base(lados, lados)
        {
            this.lados = lados;
        }

        public override string ToString()
        {
            return $"Soy un cuadrado con lados de: {lados}";
        }
    }
}
