// Exercice 10

int max = 0, min = 0, nb;
bool premierNbre = true;
string saisie;

do
{
    Console.Write("Entrez un nombre ou FIN : ");
    saisie = Console.ReadLine();
    if (saisie != "FIN")
    {
        nb = int.Parse(saisie);

        if (premierNbre)
        {
            max = nb;
            min = nb;
            premierNbre = false;
        }

        if (nb > max)
        {
            max = nb;
        }
        else if (nb < min)
        {
            min = nb;
        }
    }
} while (saisie != "FIN");

Console.WriteLine($"Le plus grand nombre est {max}");
Console.WriteLine($"Le plus petit nombre est {min}");