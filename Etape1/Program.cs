
int nombreOut;

Console.WriteLine("=====Jeu dévinette====");
Console.WriteLine("Choisissez entre 1 et 10: ");

String nombre = Console.ReadLine();

if (int.TryParse(nombre, out nombreOut))
{
    if (nombreOut >= 1 && nombreOut <= 10)
    {
        if (nombreOut == 5)
        {
            Console.WriteLine("Vous avez gagné!");
        }else
            Console.WriteLine("Vous avez Perdu");
    }
    else
    {
        Console.WriteLine("Nombre non compris entre 1 et 10, vous avez perdu");
    }
    
}
else
    Console.WriteLine("Vous n'avez pas entrer un nombre entre 1 et 10!, Vous avez perdu!!!");