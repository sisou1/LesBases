namespace GEometrie.BLL
{
    /// <summary>
    /// Représentation d'un point en 2 dimentions
    /// </summary>
    public class Point
    {
        #region champs et accessers 

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

       
        private int y;
       
        public int Y { get; set; }


        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur de point
        /// </summary>
        /// <param name="abs">Abcisse du point</param>
        /// <param name="ord">Ordonnée du point</param>
        public Point(int abs, int ord)
        {
            X = abs;
            Y = ord;
        }
        #endregion
        #region Méthode

        public override string ToString()
        {
            return $"({X};{Y})";
        }

        public double CalculerDistance(Point a)
        {
            return Math.Sqrt(
                Math.Pow(a.X - X, 2) // le this est sous entendu
                +
                Math.Pow(a.Y - Y, 2));
        }

        #endregion
    }
}