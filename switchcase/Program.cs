Console.WriteLine("Wpisz nr dnia tygodnia");
int numer = int.Parse(Console.ReadLine());
switch (numer)
{
    case 1:
        Console.WriteLine("poniedzialek");
        break;
    case 2:
        Console.WriteLine("wtorek");
        break;
    case 3:
        Console.WriteLine("sroda");
        break;
    case 4:
        Console.WriteLine("czwartek");
        break;
    case 5:
        Console.WriteLine("piatek");
        break;
    case 6:
        Console.WriteLine("sobota");
        break;
    case 7:
        Console.WriteLine("niedziela");
        break;
    default:
        Console.WriteLine("Nieznana wartość");
        break;
}
Console.ReadKey();

