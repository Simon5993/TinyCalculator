Console.WriteLine("== Tiny calculator ==");

Console.Write("Divident: ");
if (!int.TryParse(Console.ReadLine(), out int divident))
{
    Console.WriteLine("Not a number. Bye");
    return;
}

Console.Write("Divisor: ");
if (!int.TryParse(Console.ReadLine(), out int divisor))
{
    Console.WriteLine("Not a number. Bye");
    return;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{divident} / {divisor} = {divident / divisor}");
Console.ResetColor();