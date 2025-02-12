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

        public Diagrama()
        {
            Formas = new List<Forma>();
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

        public void AgregarFormas()
        {
            // Rellenar la lista con una forma de cada tipo con medidas random
            Random random = new Random();
            Formas.Add(new Cuadrado(random.Next(1, 10)));
            Formas.Add(new Rectangulo(random.Next(1, 10), random.Next(1, 10)));
            Formas.Add(new Triangulo(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10)));
            Formas.Add(new Circulo(random.Next(1, 10)));
            Formas.Add(new Elipse(random.Next(1, 10), random.Next(1, 10)));
        }

        public override string ToString()
        {
            return $"De todas las formas que contengo, el área es: {Area()} y el perímetro es: {Perimetro()}";
        }
    }
}
