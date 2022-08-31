/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

int DigitSum(int value)
{
    int sum = 0, temp = value;
    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }
    return sum;
}

Console.Write("Enter value: ");
if (int.TryParse(Console.ReadLine(), out int a))
    Console.Write($"Sum of digits of {a} = {DigitSum(a)}");