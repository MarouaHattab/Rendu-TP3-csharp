using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenduTP3
{
    public class Rectangle : FormeGeometrique
    {
        public override string Nom => "Rectangle";
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override double CalculerAire()
        {
            return Longueur * Largeur;
        }

        public override double CalculerPerimetre()
        {
            return 2 * (Longueur + Largeur);
        }
    }
}
