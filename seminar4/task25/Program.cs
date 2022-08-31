/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Pow(int value, int power)
{
    int result = 1;
    while (power > 0)
    {
        result *= value;
        power--;
    }
    return result;
}

Console.WriteLine("Enter value and power:");
if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int n))
    Console.Write($"{a}^{n} = {Pow(a, n)}");