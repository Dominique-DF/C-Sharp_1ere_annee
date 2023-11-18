// Exercice 7
int nombre1,nombre2;

Console.WriteLine("Entrez un premier nombre : ");
nombre1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez un second nombre : ");
nombre2 = int.Parse(Console.ReadLine());

// Inversion des nombres si le premier est plus grand que le second
if(nombre1 > nombre2)
{
    int temp = nombre1;
    nombre1 = nombre2;
    nombre2 = temp;
}

int somme=0;
for(int i = nombre1; i <= nombre2; i++)
{
    somme += i;
}

Console.WriteLine($"La somme des nombres entre {nombre1} et {nombre2} est {somme}");
