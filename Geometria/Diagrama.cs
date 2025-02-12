using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Diagrama
    {
        private List<Forma> formas;
        public List<Forma> Formas { set; get; }

        // Calcular suma del perímetro de todas las formas de la lista
        public double Perimetro()
        {
            double sumaPerimetro = 0;
            foreach(Forma figura in formas)
            {
                sumaPerimetro += figura.Perimetro();
            }
            return sumaPerimetro;
        }

        // Calcular suma del área de todas las formas de la lista
        public double Area()
        {
            double sumaArea = 0;
            foreach (Forma figura in formas)
            {
                sumaArea += figura.Area();
            }
            return sumaArea;
        }
    }
}
