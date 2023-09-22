Console.WriteLine("== Tiny calculator ==");

Console.Write("Divident: ");
int divident = int.Parse(Console.ReadLine());

Console.Write("Divisor: ");
int divisor = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{divident} / {divisor} = {divident / divisor}");
Console.ResetColor();