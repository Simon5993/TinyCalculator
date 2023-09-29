Console.WriteLine("== Tiny calculator ==");

int divident;
while(true)
{
    Console.Write("Divident: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out divident))
    {
        break;
       
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{input} is not a number.");
    Console.ResetColor();
}

int divisor;
while (true)
{
    Console.Write("Divident: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out divisor))
    {
        break;
        
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{input} is not a number.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{divident} / {divisor} = {divident / divisor}");
Console.ResetColor();