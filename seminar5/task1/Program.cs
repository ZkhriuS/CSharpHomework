/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int[] CreateArray3Digit(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

if (int.TryParse(Prompt("Enter length of array > "), out int size) && size > 0)
{
    int[] thisArray = CreateArray3Digit(size);
    PrintArray(thisArray);
    Console.WriteLine($" -> {CountEven(thisArray)}");
}
else
    Console.WriteLine("Array doesn't contain elements");