/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1000);
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

int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

if (int.TryParse(Prompt("Enter length of array > "), out int size) && size > 0)
{
    int[] thisArray = CreateArray(size);
    PrintArray(thisArray);
    Console.WriteLine($" -> {SumOddPosition(thisArray)}");
}
else
    Console.WriteLine("Array doesn't contain elements");

