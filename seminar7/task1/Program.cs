/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

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

int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    double[,] thisArray = CreateArray(rows, columns);
    PrintArray(thisArray);
}
else
    System.Console.WriteLine("Can't create array");