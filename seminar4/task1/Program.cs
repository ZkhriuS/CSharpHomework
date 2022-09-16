/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

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

if (int.TryParse(Prompt("Enter value: "), out int a) && int.TryParse(Prompt("Enter power: "), out int n))
    Console.Write($"{a}^{n} = {Pow(a, n)}");