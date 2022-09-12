/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

void SpiralFillArray(int[,] array, int i, int j, int counter, int step)
{
    if (j + step < array.GetLength(1) && j + step >= 0)
    {
        if (array[i, j + step] == 0)
        {
            array[i, j + step] = counter;
            SpiralFillArray(array, i, j + step, ++counter, step);
            return;
        }
    }
    if (i + step < array.GetLength(0) && i + step >= 0)
    {
        if (array[i + step, j] == 0)
        {
            array[i + step, j] = counter;
            SpiralFillArray(array, i + step, j, ++counter, step);
            return;
        }
    }
    if (counter > array.Length) return;
    else
    {
        SpiralFillArray(array, i, j, counter, step * (-1));
        return;
    }
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
int rows = PromptInt("Enter number of rows > ");
int columns = PromptInt("Enter number of columns > ");
if (rows > 0 && columns > 0)
{
    int[,] thisArray = new int[rows, columns];
    thisArray[0, 0] = 1;
    int start = 2;
    SpiralFillArray(thisArray, 0, 0, start, 1);
    PrintArray(thisArray);
}
else
    System.Console.WriteLine("Can't create array");
