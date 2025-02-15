using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenduTP3
{
    public class Carre : FormeGeometrique
    {
        public override string Nom => "Carré";
        public double Cote { get; set; }

        public Carre(double cote)
        {
            Cote = cote;
        }

        public override double CalculerAire()
        {
            return Cote * Cote;
        }

        public override double CalculerPerimetre()
        {
            return 4 * Cote;
        }
    }
}
