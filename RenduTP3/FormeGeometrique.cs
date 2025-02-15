using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenduTP3
{
    public abstract class FormeGeometrique
    {
        public abstract string Nom { get; }
        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();
    }
}
