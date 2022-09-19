/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Дополнительно написаны функции для расчета определителя квадратной матрицы
через разложение по первому столбцу  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    else throw new ArithmeticException("Wrong value");
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    (int min, int max) = SetBoundaries();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
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

int Determinant(int[,] matrix, int det)
{
    if (matrix.GetLength(0) == 1 && matrix.GetLength(1) == 1)
    {
        return matrix[0, 0];
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            det += Pow(-1, i) * matrix[i, 0] * Determinant(CutMatrix(matrix, i, 0), 0);
        }
        return det;
    }
}

int[,] CutMatrix(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int[] temp = new int[] { i, j };
            if (i >= row)
                temp[0] = i + 1;
            if (j >= column)
                temp[1] = j + 1;
            newMatrix[i, j] = matrix[temp[0], temp[1]];
        }
    }
    return newMatrix;
}

int Pow(int value, int power)
{
    int result = 1;
    while (power > 0)
    {
        result *= value;
        power--;
    }
    return result;
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
    if (thisArray.GetLength(0) == thisArray.GetLength(1))
        System.Console.WriteLine($"\nDeterminant is {Determinant(thisArray, 0)}");
    else
        System.Console.WriteLine("\nCan't calculate determinant");
}
else
    System.Console.WriteLine("Can't create array");
