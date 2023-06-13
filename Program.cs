using pierwiastek_kwadratowy;

int a = 0;
int b = 0;
int c = 0;
string input;

Pierwiastek pierwiastek = new Pierwiastek();

Console.WriteLine("Wprowadź wartość a dla równania:");


while (a == 0)
{
    
    a = int.Parse(Console.ReadLine());
    if (a == 0)
    {
        Console.WriteLine("Nieprawidłowa wartość. Wprowadź liczbę ponownie. Wartość a nie może być zerem.");
    }
}

Console.WriteLine("Wprowadź wartość b dla równania:");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź wartość c dla równania:");
c = int.Parse(Console.ReadLine());

pierwiastek.obliczPierwiastki(a, b, c);
Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
Console.ReadKey();