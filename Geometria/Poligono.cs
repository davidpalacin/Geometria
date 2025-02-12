using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Poligono : Forma
    {
        private int numeroLados;

        public int NumeroLados { get; set; }

        public Poligono(int numeroLados)
        {
            NumeroLados = numeroLados;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Soy un polígono de {NumeroLados} lados";
        }
    }
}
