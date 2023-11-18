// Exercice 12

var rand = new Random();

int nb = rand.Next(1, 100);

Console.WriteLine("Devinez le nombre entre 1 et 100");

int nbCoups = 0, saisie;

do {
    nbCoups++;
    saisie = int.Parse(Console.ReadLine());

    if (saisie < nb) {
        Console.WriteLine("C'est plus");
    } else if (saisie > nb) {
        Console.WriteLine("C'est moins");
    } else {
        Console.WriteLine($"Bravo, vous avez trouvé en {nbCoups} coups");
    }
} while (nbCoups < 10 && nb != saisie);

if (nbCoups == 10) {
    Console.WriteLine($"Perdu, le nombre était {nb}");
}