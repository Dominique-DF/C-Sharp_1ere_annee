const int SIZE = 10; // Taille du tableau

int adventofcode01(string fileloc)
{
    // Somme recherchée
    int somme = 0;
    // Déclare le tableau
    char[,] tab = new char[SIZE, SIZE];
    int x=0,y=0;
    // Lire le fichier ligne par ligne
    IEnumerable<string> lines = File.ReadLines(fileloc);
    foreach (string line in lines) // Pour chaque ligne
    {
        foreach (char c in line) // Pour chaque caractère de la ligne
        {
            tab[y,x] = c; // On remplit le tableau avec le caractère lu
            x++;  // On passe à la colonne suivante du tableau
        }
        y++; // Ligne suivante et retour à la première colonne
        x=0;
    }

    // Le tableau est complété, on le parcourt pour chercher les nombres avec des "voisins spéciaux"
    for(y=0;y<SIZE;y++) {
        int nombre=0;
        bool voisin = false;
        for(x=0;x<SIZE;x++)
        {
            if (tab[y,x]>='0' && tab[y,x]<='9')
            {
                // On est passé sur un chiffre, on l'ajoute à ce qu'on a déjà lu *10 (pour passer de 12 à 123 par exemple)
                nombre= nombre*10+int.Parse(tab[y,x].ToString());
                // On regarde s'il est voisin à un caractère spécial
                if (testVoisins(tab,x,y)) 
                    voisin = true;
            }
            else {
                // Le nombre lu était voisin à un caractère spécial donc on l'ajoute à la somme
                if (voisin) {
                    somme+=nombre;
                    voisin = false;
                }
                nombre=0;
            }
        }
    }
    return somme;
}

bool isSpecialChar(char c) {
    // On définit la liste des caractères dits spéciaux
    char[] spec = {'#','$','*','+','-','/','%'};
    bool trouve = false;
    foreach(char cs in spec)
        if (c==cs)
            trouve = true;
    return trouve;
}

bool testVoisins(char[,] tab, int x, int y)
{
    bool res = false; // par principe y a pas de car spécial

    // Test des voisins si car spécial res=true
    for(int yy=y-1;yy<=y+1;yy++) {
        for(int xx=x-1;xx<=x+1;xx++) {
            // On vérifie qu'on ne sort pas des limites du tableau
            if (xx>=0 && xx<SIZE && yy>=0 && yy<SIZE) {
                // Si c'est un caractère spécial
                if (isSpecialChar(tab[yy,xx]))
                    res = true;
            }
        }
    }
    return res;
}

// Chemin du fichier contenant les données à lire
string monFichier = @"C:\Users\domin\OneDrive - Dijon formation\Bureau\Nouveau dossier (2)\data.txt";

int res = adventofcode01(monFichier);

Console.WriteLine(res);
