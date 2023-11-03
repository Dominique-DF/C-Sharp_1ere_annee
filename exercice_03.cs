// Exercice 3
int annee;
Console.WriteLine("Entrez une année : ");
annee = int.Parse(Console.ReadLine());
if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
{
    Console.WriteLine("L'année {0} est bissextile", annee);
}
else
{
    Console.WriteLine("L'année {0} n'est pas bissextile", annee);
}
