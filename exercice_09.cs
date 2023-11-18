// Exercice 9

int max=0, min=0, nb;

for (int i = 0; i < 10; i++)
{
    Console.Write("Entrez un nombre : ");
    nb = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        max = nb;
        min = nb;
    }
    else
    {
        if (nb > max)
        {
            max = nb;
        }
        if (nb < min)
        {
            min = nb;
        }
    }
}

Console.WriteLine("Le plus grand nombre est : " + max);
Console.WriteLine("Le plus petit nombre est : " + min);