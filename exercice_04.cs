// Exercice 4
int heureDepart, minDepart, heureTrajet, minTrajet;
int heureArrivee, minArrivee;

Console.Write("Heure de départ : ");
heureDepart = int.Parse(Console.ReadLine());
Console.Write("Minute de départ : ");
minDepart = int.Parse(Console.ReadLine());
Console.Write("Durée du trajet (heures) : ");
heureTrajet = int.Parse(Console.ReadLine());
Console.Write("Durée du trajet (minutes) : ");  
minTrajet = int.Parse(Console.ReadLine());

heureArrivee = heureDepart + heureTrajet;
minArrivee = minDepart + minTrajet;
if (minArrivee >= 60)
{
    heureArrivee++;
    minArrivee -= 60;
}
if (heureArrivee >= 24)
{
    heureArrivee -= 24;
}

// OU ALORS SECONDE VERSION

// int arrivee = heureDepart*60 + minDepart + heureTrajet*60 + minTrajet;
// heureArrivee = (arrivee / 60) % 24 ;
// minArrivee = arrivee % 60;

Console.WriteLine("Heure d'arrivée : " + heureArrivee + "h" + minArrivee);