using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Circulo : Elipse
    {
        private double radio;

        public double Radio {set; get;}

        public Circulo(double radio) : base(radio, radio)
        {
            Radio = radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"Soy un círculo de radio: {Radio}. Mi área es: {Area()}";
        }
    }
}
