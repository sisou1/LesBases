using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEometrie.BLL
{

    internal class Triangle : Polygone
    {
        public bool EstIocele { get; private set; }

        public bool EstEquilateral { get; private set; }

        public Triangle(Point a, Point b, Point c) : base(a, b, c)//j'apelle le constructeur de poly
        {
            var cote1 = a.CalculerDistance(b);
            var cote2 = b.CalculerDistance(c);
            var cote3 = c.CalculerDistance(a);

            //2 coté même longueur

            EstIocele = cote1 == cote2 || cote1== cote3; || cote2== cote3;

            //les 3 sont pareil
            EstEquilateral = cote1 == cote2&& cote2== cote3;

        }
    }
}
