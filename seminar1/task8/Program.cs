/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8  */
Console.Write("Enter a value> ");
if (int.TryParse(Console.ReadLine(), out int first))
{
    int start = 1, step = 2;
    if (first < start)
    {
        start--;
        step = -2;
    }
    else start++;
    System.Console.Write(" -> ");
    while (first - start > 1 || first - start < -1)
    {
        Console.Write($"{start}, ");
        start += step;
    }
    Console.Write($"{start} ");
}
else
{
    Console.WriteLine(" -> Incorrect input");
}