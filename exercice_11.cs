// Exercice 11

float prix, donne;
int rendu;

Console.WriteLine("Prix de l'article : ");
prix = float.Parse(Console.ReadLine());
Console.WriteLine("Montant donné : ");
donne = float.Parse(Console.ReadLine());

rendu = (int) (donne*100 - prix*100);

if (rendu >= 5000)
{
    Console.WriteLine($"{rendu/5000} billets de 50€");
    rendu = rendu % 5000;
}
if (rendu >= 2000)
{
    Console.WriteLine($"{rendu/2000} billets de 20€");
    rendu = rendu % 2000;
}
if (rendu >= 1000)
{
    Console.WriteLine($"{rendu/1000} billets de 10€");
    rendu = rendu % 1000;
}
if (rendu >= 500)
{
    Console.WriteLine($"{rendu/500} billets de 5€");
    rendu = rendu % 500;
}
if (rendu >= 200)
{
    Console.WriteLine($"{rendu/200} pièces de 2€");
    rendu = rendu % 200;
}
if (rendu >= 100)
{
    Console.WriteLine($"{rendu/100} pièces de 1€");
    rendu = rendu % 100;
}
if (rendu >= 50)
{
    Console.WriteLine($"{rendu/50} pièces de 50 centimes");
    rendu = rendu % 50;
}
if (rendu >= 20)
{
    Console.WriteLine($"{rendu/20} pièces de 20 centimes");
    rendu = rendu % 20;
}
if (rendu >= 10)
{
    Console.WriteLine($"{rendu/10} pièces de 10 centimes");
    rendu = rendu % 10;
}
if (rendu >= 5)
{
    Console.WriteLine($"{rendu/5} pièces de 5 centimes");
    rendu = rendu % 5;
}


