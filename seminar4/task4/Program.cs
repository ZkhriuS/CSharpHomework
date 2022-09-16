/* Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
8 1 2 4 4 5 3 1 -> 5
1 2 6 9 8 1 1 1 -> 8
2 1 2 1 1 1 1 1 -> 1
1 2 1 2 1 1 1 1 -> 1
1 2 3 4 5 6 7 8 -> 7
1 2 3 4 5 6 8 7 -> 7  */

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
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int SecondMax(int[] array)
{
    int secondMax = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        else if (array[i] > secondMax && array[i] != max)
        {
            secondMax = array[i];
        }
        if (secondMax == max)
            secondMax = array[i];
    }
    return secondMax;
}

if (int.TryParse(Prompt("Enter number of elements: "), out int count) && count > 0)
{
    int[] thisArray = CreateArray(count);
    PrintArray(thisArray);
    if (thisArray.Length >= 2)
    {
        Console.WriteLine($"Second maximum is {SecondMax(thisArray)}");
    }
    else
        System.Console.WriteLine($"Array contains of {thisArray.Length} element");
}
else Console.WriteLine("Array doesn't contain elements");
