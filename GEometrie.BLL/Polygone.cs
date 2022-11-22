using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEometrie.BLL
{
    public class Polygone : IForme, IEnumerable<Point>
    {
        private List<Point> lesPoints;

        //création de la fonction Count pour l'objet polygone
        public int Count
        {
            get { return lesPoints.Count;}
        }

        //indexeur
        public Point this[int index]
        {
            get { return lesPoints[index];}
        }

        public Polygone(Point a, Point b, Point c, params Point[] autrePoints)
        {
            lesPoints= new List<Point>();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);
            lesPoints.AddRange(autrePoints);
        }
        public double CalculerPerimetre()
        {
            double distance = 0;

            for (int i = 0; i < lesPoints.Count - 1; i++)
            {
                distance += lesPoints[i].CalculerDistance(lesPoints[i+1]);
            }
            return distance += lesPoints[lesPoints.Count - 1].CalculerDistance(lesPoints[0]);
        }
        public override string ToString()
        {
            
            var LaChaine = new StringBuilder();
            LaChaine.Append("[");
            /*
            foreach (var p in lesPoints)
            {

                LaChaine.Append(p.ToString());
            }
            */
            LaChaine.Append(string.Join(", ", lesPoints));
            LaChaine.Append("]");
            return LaChaine.ToString();
        }

        public IEnumerator<Point> GetEnumerator()
        {
            // version facile : on renvoie le GetEnumerator de la liste
            //return lesPoints.GetEnumeratoor();

            //yield return, return sans casser
            foreach (var item in lesPoints)
            {
                yield return item;
            }
            throw new NotImplementedException();
        }
        //obliger de mettre ça pour des raison de compatibilité
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
