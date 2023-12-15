int adventofcode01(string fileloc)
{
    // Somme recherchée
    int somme = 0;
    // Lire le fichier ligne par ligne
    IEnumerable<string> lines = File.ReadLines(fileloc);
    foreach (string line in lines) // Pour chaque ligne
    {
        char premierChiffre = '.';
        char dernierChiffre = '.';
        foreach (char c in line) // Pour chaque caractère de la ligne
        {
            if (c >= '0' && c <= '9') // Si c'est un chiffre
            {
                if (premierChiffre == '.') // Si c'est le premier chiffre rencontré
                {
                    premierChiffre = c;
                }
                dernierChiffre = c;
            }
        }
        int valeur = int.Parse(premierChiffre.ToString() + dernierChiffre.ToString());
        somme += valeur;
    }
    return somme;
}


// Chemin du fichier contenant les données à lire
string monFichier = @"C:\Users\domin\OneDrive - Dijon formation\Bureau\Nouveau dossier\adventofcode01\data.txt";

int res = adventofcode01(monFichier);

Console.WriteLine(res);
