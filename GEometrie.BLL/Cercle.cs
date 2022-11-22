using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEometrie.BLL
{
    public class Cercle : IForme
    {
        //le cercle implémentte l'interface IForme
        public Point Centre { get; private set; }

        public int Rayon { get; set; }
        public Cercle(Point centre, int rayon)
        {
            Rayon = rayon;
            Centre = centre;
        }
        public override string ToString()
        {
            return $"{Centre} R={Rayon}";
        }
        public double CalculerPerimetre()
        {
            return Math.PI * 2 * Rayon;
        }
    }
}
