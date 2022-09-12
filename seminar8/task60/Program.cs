/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

int[,,] Create3DArray()
{
    int x = PromptInt("Enter size of 1 dimension > ");
    int y = PromptInt("Enter size of 2 dimension > ");
    int z = PromptInt("Enter size of 3 dimension > ");
    if (x > 0 && y > 0 && z > 0)
    {
        int[,,] array = new int[x, y, z];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    int temp = new Random().Next(10, 100);
                    while (!IsUnique(array, temp))
                        temp = new Random().Next(10, 100);
                    array[i, j, k] = temp;
                }
        return array;
    }
    System.Console.WriteLine("Can't create array");
    return null;
}

bool IsUnique(int[,,] array, int current)
{
    foreach (var el in array)
        if (el == current)
            return false;
    return true;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] thisArray = Create3DArray();
Print3DArray(thisArray);