﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Elipse : Forma
    {
        private double radioMayor;
        private double radioMenor;

        public double RadioMayor { get; set; }
        public double RadioMenor { get; set; }


        public Elipse (double radioMayor, double radioMenor)
        {
            RadioMayor = radioMayor;
            RadioMenor = radioMenor;
        }

        public override double Area()
        {
            return Math.PI * RadioMayor * RadioMenor;
        }

        public override double Perimetro()
        {
            // Fórmula de Ramanujan
            return Math.PI * (3 * (RadioMayor + RadioMenor) - Math.Sqrt((3 * RadioMayor + RadioMenor) * (RadioMayor + 3 * RadioMenor)));
        }

        public override string ToString()
        {
            return $"Soy un Elipse con radio mayor: {RadioMayor} y menor: {RadioMenor}. Mi área es: {Area()}. Mi perímetro es: {Perimetro()}";
        }
    }
}
