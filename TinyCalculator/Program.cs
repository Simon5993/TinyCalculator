using System.ComponentModel.Design;

Console.WriteLine("== Tiny calculator ==");

int dividend = ReadNumber("Dividend");
int divisor = ReadNumber("Divisor");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
Console.ResetColor();

int ReadNumber(string s)
{
    int val;
    while (true)
    {
        Console.Write($"{s}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out val))
        {
            return val;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{input} is not a number");
        Console.ResetColor();
    }
    

}