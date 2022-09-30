/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов. */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int CountSumInRow(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[row, i];
    return sum;
}

int IndexMinSumRow(int[,] array)
{
    int minSumIndex = 0;
    for (int i = 1; i < array.GetLength(0); i++)
        if (CountSumInRow(array, minSumIndex) > CountSumInRow(array, i))
            minSumIndex = i;
    return minSumIndex;
}

int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    int[,] thisArray = CreateArray(rows, columns);
    PrintArray(thisArray);
    System.Console.WriteLine($"Row with minimum sum: {IndexMinSumRow(thisArray) + 1}");
}
else
    System.Console.WriteLine("Can't create array");
