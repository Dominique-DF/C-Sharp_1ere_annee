// Exercice 2
double note;
Console.WriteLine("Entrez une note : ");
note = double.Parse(Console.ReadLine());
while (note < 0 || note > 20)
{
    Console.WriteLine("Entrez une note valide : ");
    note = double.Parse(Console.ReadLine());
}
