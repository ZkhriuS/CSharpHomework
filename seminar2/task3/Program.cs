/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

void ThirdDigit(int value)
{
    int power = 1;
    while (value / power > 999) power *= 10;
    if (value > 99)
        Console.WriteLine($"third digit of {value} is {value / power % 10}");
    else
        Console.WriteLine($"there isn't third digit in {value}");
}

if (int.TryParse(Prompt("Enter 3-digit number > "),
            out int myValue))
    ThirdDigit3(myValue);
else
    Console.WriteLine("Not a number!");