/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
*/

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

void DescInRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        DescInRow(array, i);
    }
}

void DescInRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            if (array[row, j] > array[row, i])
            {
                int temp = array[row, i];
                array[row, i] = array[row, j];
                array[row, j] = temp;
            }
        }
    }
}

int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    int[,] thisArray = CreateArray(rows, columns);
    PrintArray(thisArray);
    DescInRows(thisArray);
    System.Console.WriteLine();
    PrintArray(thisArray);
}
else
    System.Console.WriteLine("Can't create array");