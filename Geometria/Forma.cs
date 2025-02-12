
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Forma
    {
        public override string ToString()
        {
            return "Soy una forma";
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }

    }
}
