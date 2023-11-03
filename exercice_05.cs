// Exercice 4
int heureDepart, minDepart, heureArrivee, minArrivee, heureTrajet, minTrajet;

Console.Write("Heure de départ : ");
heureDepart = int.Parse(Console.ReadLine());
Console.Write("Minute de départ : ");
minDepart = int.Parse(Console.ReadLine());
Console.Write("Heure d'arrivée : ");
heureArrivee = int.Parse(Console.ReadLine());
Console.Write("Minute d'arrivée : ");
minArrivee = int.Parse(Console.ReadLine());

if (heureArrivee < heureDepart)
{
    heureArrivee += 24;
}

heureTrajet = heureArrivee - heureDepart;
minTrajet = minArrivee - minDepart;

if (minTrajet < 0)
{
    minTrajet += 60;
    heureTrajet--;
}

Console.WriteLine($"Le trajet a duré {heureTrajet} heures et {minTrajet} minutes.");
