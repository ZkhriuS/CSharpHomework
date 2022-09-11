/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double AverageInColumn(int[,] array, int index)
{
    double avg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avg += array[i, index];
    }
    return avg / array.GetLength(0);
}

int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    int[,] thisArray = CreateArray(rows, columns);
    PrintArray(thisArray);
    System.Console.Write("Average in each column: ");
    for (int i = 0; i < thisArray.GetLength(1); i++)
        System.Console.Write($"{AverageInColumn(thisArray, i):f1}\t");
}
else
    System.Console.WriteLine("Can't create array");
