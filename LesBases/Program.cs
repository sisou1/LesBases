//Comentaire
/*
 * et la c'est pusieur lignes
 * */

//Pour ranger son code
#region Variables

//le C# est fortement typé
//unevariable ne peut pas changer de type
using LesBases;

int entier;
entier = 2;

//inférence de type
//pour gagner du temps à l'écriture, le compilateur
//peut choisir le type a partir de ce qu"on met dedans

var entier2 = 9;
var ex = new InvalidOperationException();

var entier3 = entier + entier2;


#endregion

#region Tableaux

var tab = new int[3]; //il faut donner la taille
tab[0] = 7;
tab[1] = 37;
tab[2] = 6;

//Quand on connais lse valeurs ds le début on peu assigner en 1 ligne

var tab2 = new int[] { 7, 8, 9 }; //3 dimension 
var tab3 = new int[4,3,8];
tab3[0, 1, 7] = 7;

//tableau de tableau
var tab4 = new int[2][];
tab4[0] = new int[6];
tab4[1] = new int[3];

tab4[1][2] = 6;

#endregion

#region Structure conditionnelles et les boucles

if (true)
{

}
else
{

}
switch (entier)
{
    case 1:
        Console.WriteLine("c'est le 1");
        break;
    case 2:
    case 3:
        Console.WriteLine("c'est le 2 ou 3"); break;
    default: Console.WriteLine("c'est autre chose");
        break;
}
//le Switch est utilisé avec les énumeration
var jourDesEnfants = JoursDelaSemaine.Mercredi;

switch (jourDesEnfants)
{
    case JoursDelaSemaine.Lundi:
        break;
    case JoursDelaSemaine.Mardi:
        break;
    case JoursDelaSemaine.Mercredi:
        break;
    case JoursDelaSemaine.Jeudi:
        break;
    case JoursDelaSemaine.Vendredi:
        break;
    case JoursDelaSemaine.Samedi:
        break;
    case JoursDelaSemaine.Dimanche:
        break;
    default:
        break;
}

for (int i = 0;i < 10;i++)
{

}

while(true)
{

}
do
{

} while (true);

foreach (var item in tab)
{
    //dans item j''ai la case courante
}


#endregion


#region

var liste = new List<int>(); // on choisis le type avec lequel on travaille....
liste.Add(3);
liste.Add(4);
liste.Add(5);
liste.Add(2);


foreach (var item in liste)
{
    Console.WriteLine(item);
}


#endregion