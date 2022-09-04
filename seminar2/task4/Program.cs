/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным. */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

string Weekends(int value)
{
    if (value > 0 && value < 8)
    {
        Console.Write(value);
        if (value < 6) return " -> no";
        return " -> yes";
    }
    return "Not a day of the week!";
}

if (int.TryParse(Prompt("Enter day of the week > "),
            out int day))
    Console.WriteLine(Weekends(day));
else
    Console.WriteLine("Not a number!");