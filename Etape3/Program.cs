using System.Collections;

int debut;
int fin;
int nombreTentative = 0, nombrePossibilite = 10;

ArrayList tentatives = new ArrayList();
Console.WriteLine("=====Jeu dévinette====");
Console.WriteLine("Entrez la borne inférieure: ");
String debutSt = Console.ReadLine();
Console.WriteLine("Entrez la borne Supérieure: ");
String finSt = Console.ReadLine();
if (int.TryParse(debutSt, out debut) && int.TryParse(finSt, out fin))
{
    Random aleatoire = new Random();
    int nombreADeviner = aleatoire.Next(debut, fin);

    int nombre;
    String nombreSt;

    while (nombreTentative < nombrePossibilite)
    {
        Console.WriteLine("Entrez le nombre à déviner: ");
        nombreSt = Console.ReadLine();
        tentatives.Add(nombreSt);

        if (int.TryParse(nombreSt, out nombre))
        {
            if (nombre >= debut && nombre <= fin)
            {
                if (nombre != nombreADeviner)
                {
                    nombreTentative++;
                    Console.WriteLine("Vous n'avez pas entré le bon nombre! il vous reste " + (nombrePossibilite - nombreTentative) + " tentative(s)");
                    Console.WriteLine();
                
                }
                else
                {
                    nombreTentative++;
                    Console.WriteLine("Vous avez Gagné! ");
                    Console.WriteLine("Nombre de tentatives: " + nombreTentative);
                    Console.WriteLine("Votre note est de " + (nombrePossibilite / nombreTentative));
                    return;
                }
                
            }
            else
            {
                nombreTentative++;
                Console.WriteLine("Attention le nombre doit être compris entre " + debut + " et " + fin);
                Console.WriteLine("Il vous reste " + (nombrePossibilite - nombreTentative) + " tentative(s)");
            }
            
        }
        else
        {
            nombreTentative++;
            Console.WriteLine("Vous n'avez pas entré un nombre! Il vous reste " + (nombrePossibilite - nombreTentative) + " Tentatives");
            Console.WriteLine();
        }
    }
 
    Console.WriteLine("Vous avez perdu! ");
    Console.WriteLine("Nombre de tentatives: " + nombreTentative);
}
else
{
    Console.WriteLine("Vous n'avez pas entré des bornes en nombre");
}