using System.ComponentModel.Design;

Console.WriteLine("== Tiny calculator ==");

int dividend = ReadNumber("Dividend");

string op = GetOperator();


while (dividend > 0)
{

    int divisor = ReadNumber("Divisor");

    if (divisor == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Divisor must not be zero!");
        Console.ResetColor();
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        if (op == "/")
        {
            Console.WriteLine($"{dividend} {op} {divisor} = {dividend / divisor}");
            dividend = dividend / divisor;
        }
        if (op == "*")
        {
            Console.WriteLine($"{dividend} {op} {divisor} = {dividend * divisor}");
            dividend = dividend * divisor;
        }
        if (op == "+")
        {
            Console.WriteLine($"{dividend} {op} {divisor} = {dividend + divisor}");
            dividend = dividend + divisor;
        }
        if (op == "-")
        {
            Console.WriteLine($"{dividend} {op} {divisor} = {dividend - divisor}");
            dividend = dividend - divisor;
        }
        Console.ResetColor();
    } 
}


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

    string GetOperator()
    {
        string val;
        while (true)
        {
            Console.Write($"Select operator: ");
            val = Console.ReadLine();
            if (val == "+" || val == "-" || val == "*" || val == "/")
            {
                return val;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{val} is not an operator");
            Console.ResetColor();
        }
    }
