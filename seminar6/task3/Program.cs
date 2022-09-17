/* Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int[,] GenerateMatrix(int rows, int columns)
{
    if (rows > 0 && columns > 0)
    {
        int[,] matrix = new int[rows, columns];
        (int min, int max) = SetBoundaries();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = new Random().Next(min, max);
            }
        }
        return matrix;
    }
    System.Console.WriteLine("Can't create matrix of such size");
    return null;
}

void PrintMatrix(int[,] array)
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

(int, int) SetBoundaries()
{
    int min = 0, max = 100;
    System.Console.Write($"Default boundaries of random: [{min}, {max - 1}]. Change? (y/n) > ");
    string answer = Console.ReadLine() ?? String.Empty;
    if (answer == "y")
    {
        if (!int.TryParse(Prompt("Low boundary > "), out min))
        {
            System.Console.WriteLine("Wrong value. Boundaries were set to default");
            return (0, 100);
        }
        if (!int.TryParse(Prompt("High boundary > "), out max))
        {
            System.Console.WriteLine("Wrong value. Boundaries were set to default");
            return (0, 100);
        }
        return (min, max);
    }
    return (0, 100);
}

int MaxInRow(int[,] array, int index)
{
    int max = array[index, 0];
    for (int i = 1; i < array.GetLength(1); i++)
    {
        if (array[index, i] > max)
            max = array[index, i];
    }
    return max;
}

int MinInColumn(int[,] array, int index)
{
    int min = array[0, index];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (array[i, index] < min)
            min = array[i, index];
    }
    return min;
}

int Sum(int[,] array, char type)
{
    int sum = 0;
    if (type == '>')
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum += MaxInRow(array, i);
    }
    if (type == '<')
    {
        for (int i = 0; i < array.GetLength(1); i++)
            sum += MinInColumn(array, i);
    }
    return sum;
}

if (int.TryParse(Prompt("Enter number of rows > "), out int rows) && int.TryParse(Prompt("Enter number of columns > "), out int columns))
{
    int[,] matrix = GenerateMatrix(rows, columns);
    PrintMatrix(matrix);
    System.Console.WriteLine($"Difference between {Sum(matrix, '>')} and {Sum(matrix, '<')} is {Sum(matrix, '>') - Sum(matrix, '<')}");
}
else
    System.Console.WriteLine("Wrong input");