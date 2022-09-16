/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

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
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(" -> [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

if (int.TryParse(Prompt("Enter number of elements: "), out int count) && count > 0)
{
    int[] thisArray = CreateArray(count);
    PrintArray(thisArray);
}
else Console.WriteLine("Array doesn't contain elements");