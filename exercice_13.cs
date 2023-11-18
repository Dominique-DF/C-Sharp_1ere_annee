// Exercice 13

string numCB;

Console.WriteLine("Entrez votre numéro de carte bancaire :");
numCB = Console.ReadLine();

if (numCB.Length != 16)
{
    Console.WriteLine("Votre numéro de carte bancaire est invalide.");
}
else
{
    int somme = 0;
    for(int i = 0; i < numCB.Length; i++)
    {
        int chiffre = int.Parse(numCB[i].ToString());
        if (i % 2 == 0)
        {
            chiffre *= 2;
            if (chiffre > 9)
            {
                chiffre -= 9;
            }
        }
        somme += chiffre;
    }
    if (somme % 10 == 0)
    {
        Console.WriteLine("Votre numéro de carte bancaire est valide.");
    }
    else
    {
        Console.WriteLine("Votre numéro de carte bancaire est invalide.");
    }
}