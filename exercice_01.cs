// Exercice 1
int annee_actuelle, annee_naissance, age;
Console.Write("Année actuelle : ");
annee_actuelle = int.Parse(Console.ReadLine());
Console.Write("Année de naissance : ");
annee_naissance = int.Parse(Console.ReadLine());
age = annee_actuelle - annee_naissance;
if (age>=18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
    Console.WriteLine("Il vous reste {0} ans avant la majorité", 18 - age);
}

