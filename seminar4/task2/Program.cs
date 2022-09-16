/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

int DigitSum(int value)
{
    int sum = 0;
    if (value < 0) value *= -1;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

Console.Write("Enter value: ");
if (int.TryParse(Console.ReadLine(), out int a))
    Console.Write($"Sum of digits of {a} = {DigitSum(a)}");