/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    else throw new ArithmeticException("Wrong value");
}

double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    (int min, int max) = SetBoundaries();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }
    return array;
}

(int, int) SetBoundaries()
{
    int min = 0, max = 100;
    System.Console.Write($"Default boundaries of random: [{min}, {max - 1}]. Change? (y/n) > ");
    string answer = Console.ReadLine() ?? String.Empty;
    if (answer == "y")
    {
        min = PromptInt("Low boundary > ");
        max = PromptInt("High boundary > ");
        if (max <= min)
        {
            System.Console.WriteLine("Max must be greater than min. Boundaries were set to default");
            return (0, 100);
        }
    }
    return (min, max);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

void ValueOfIndexes(int row, int column, double[,] array)
{
    if (row < array.GetLength(0) && row >= 0 && column < array.GetLength(1) && column >= 0)
        System.Console.WriteLine($"Element[{row}][{column}] = {array[row, column]:f2}");
    else
        System.Console.WriteLine("No element with such indexes");
}

int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    double[,] thisArray = CreateArray(rows, columns);
    PrintArray(thisArray);
    ValueOfIndexes(PromptInt("Enter index of row > "), PromptInt("Enter index of column > "), thisArray);
}
else
    System.Console.WriteLine("Can't create array");
