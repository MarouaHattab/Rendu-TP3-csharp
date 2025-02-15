using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenduTP3
{
    public class Cercle : FormeGeometrique
    {
        public override string Nom => "Cercle";
        public double Rayon { get; set; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public override double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }

        public override double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
    }
}
