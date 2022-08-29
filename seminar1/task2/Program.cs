/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Enter 2 values: ");
if (double.TryParse(Console.ReadLine(), out double first) && double.TryParse(Console.ReadLine(), out double second))
{
    if (first > second) Console.WriteLine($"max = {first}, min ={second}");
    else Console.WriteLine($"max = {second}, min ={first}");
}
else
{
    Console.WriteLine("Incorrect input");
}
