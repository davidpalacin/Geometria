using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Diagrama
    {
        public List<Forma> Formas { get; set; }  // Lista de formas correctamente usada

        public Diagrama(List<Forma> formas)
        {
            // Asignamos la lista recibida a la propiedad Formas
            Formas = formas ?? new List<Forma>();  // Evita un posible null
        }

        public double Perimetro()
        {
            double sumaPerimetro = 0;
            foreach (Forma figura in Formas)
            {
                sumaPerimetro += figura.Perimetro();
            }
            return sumaPerimetro;
        }

        public double Area()
        {
            double sumaArea = 0;
            foreach (Forma figura in Formas)
            {
                sumaArea += figura.Area();
            }
            return sumaArea;
        }

        public override string ToString()
        {
            return $"De todas las formas que contengo, el área es: {Area()} y el perímetro es: {Perimetro()}";
        }
    }
}
