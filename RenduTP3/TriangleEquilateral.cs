using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenduTP3
{
    public class TriangleEquilateral : FormeGeometrique
    {
        public override string Nom => "Triangle Équilatéral";
        public double Cote { get; set; }

        public TriangleEquilateral(double cote)
        {
            Cote = cote;
        }

        public override double CalculerAire()
        {
            return (Math.Sqrt(3) / 4) * Cote * Cote;
        }

        public override double CalculerPerimetre()
        {
            return 3 * Cote;
        }
    }
}
