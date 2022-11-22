using GEometrie.BLL;

var p1 = new Point(5, 6);
var p2 = new Point(6, 8);
var p3 = new Point(7, 11);
var p4 = new Point(8, 11);

var listeDeFormes = new List<IForme>();


listeDeFormes.Add(new Cercle(p1, 3));
listeDeFormes.Add(new Polygone(p1, p2, p3, p4));

foreach (var item in listeDeFormes)
{
    Console.WriteLine($"Le périmètre de {item} est {item.CalculerPerimetre()}");
} 


Console.ReadKey();

