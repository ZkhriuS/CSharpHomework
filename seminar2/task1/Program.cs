/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. */

void SecondDigit3(int value)
{
    if (value > 99 && value < 1000)
        Console.WriteLine($"Second digit of {value} is {value / 10 % 10}");
    else
        Console.WriteLine($"{value} is not a 3-digit number");
}

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}
if (int.TryParse(Prompt("Enter 3-digit number > "),
            out int myValue))
    SecondDigit3(myValue);
else
    Console.WriteLine("Not a number!");