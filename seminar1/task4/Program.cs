/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */
Console.WriteLine("Enter 3 values: ");
if (double.TryParse(Console.ReadLine(), out double first)
    && double.TryParse(Console.ReadLine(), out double second)
    && double.TryParse(Console.ReadLine(), out double third))
{
    double max = first;
    if (second > max) max = second;
    if (third > max) max = third;
    Console.WriteLine($" -> max = {max}");
}
else
{
    Console.WriteLine("Incorrect input");
}
