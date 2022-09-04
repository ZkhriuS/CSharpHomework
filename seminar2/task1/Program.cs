/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. */

void SecondDigit3(int value)
{
    if (value > 99 && value < 1000)
        Console.WriteLine($"second digit of {value} is {value / 10 % 10}");
    else
        Console.WriteLine($"{value} is not a 3-digit number");
}

if (int.TryParse(Console.ReadLine(), out int myValue))
    SecondDigit3(myValue);
else
    Console.WriteLine("Not a number!");