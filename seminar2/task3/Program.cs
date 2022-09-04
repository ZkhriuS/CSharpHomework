/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

void ThirdDigit(int value)
{
    int power = 1, absValue = value;
    if (value < 0) absValue *= -1;
    while (absValue / power > 999) power *= 10;
    if (absValue > 99)
        Console.WriteLine($"Third digit of {value} is {absValue / power % 10}");
    else
        Console.WriteLine($"There isn't third digit in {value}");
}

if (int.TryParse(Prompt("Enter integer number > "),
            out int myValue))
    ThirdDigit(myValue);
else
    Console.WriteLine("Not a number!");