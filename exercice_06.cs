// Exercice 6
int nombre;

Console.WriteLine("Entrez un nombre : ");
nombre = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{nombre} x {i} = {nombre * i}");
    // OU Console.WriteLine(nombre + " x " + i + " = " + (nombre * i));
}
