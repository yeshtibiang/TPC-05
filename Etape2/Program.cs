using System.Collections;

string continuer;
int continuerOut = 1;
ArrayList list = new ArrayList();

while (continuerOut == 1)
{
    Console.WriteLine("Choisissez entre 1 et 10: ");

    String nombre = Console.ReadLine();
    int nombreOut;
    
    if (int.TryParse(nombre, out nombreOut))
    {
        list.Add(nombreOut);
        if (nombreOut >= 1 && nombreOut <= 10)
        {
            
            if (nombreOut == 5)
            {
                Console.WriteLine("Vous avez gagné!");
                Console.Write("Tentatives : ");
                foreach (var item in list)
                {
                    Console.Write(item + ", " );
                }

                return;
            }
            else
            {
                Console.WriteLine("Vous avez perdu!");
                Console.WriteLine("Voulez vous continuer? choisissez entre 1 pour oui et autre pour non: ");
                continuer = Console.ReadLine();
                int.TryParse(continuer, out continuerOut);
            }

        }
        else
        {
            Console.WriteLine("Nombre non compris entre 1 et 10, vous avez perdu");
            Console.WriteLine("Voulez vous continuer? entre 1 pour oui et autre pour non: ");
            continuer = Console.ReadLine();
            int.TryParse(continuer, out continuerOut);
            
        }

    }
    else
    {
        list.Add(nombre);
        Console.WriteLine("Vous n'avez pas entrer un nombre entre 1 et 10!, Vous avez perdu!!!");
        Console.WriteLine("Voulez vous continuer? choisissez entre 1 pour oui et autre pour non: ");
        continuer = Console.ReadLine();
        int.TryParse(continuer, out continuerOut);
    }
        
}

Console.Write("Tentatives : ");
foreach (var item in list)
{
    Console.Write(item + ", " );
}