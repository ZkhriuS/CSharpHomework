/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементом массива.
[3 7 22 2 78] -> 76  */

double[] CreateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {

        array[i] = new Random().Next(1000) /
        Math.Pow(10, new Random().Next(4));
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i].ToString().Replace(',', '.')}, ");
    }
    Console.Write($"{array[array.Length - 1].ToString().Replace(',', '.')}]");
}

double DiffMaxMin(double[] array)
{
    int maxPosition = 0;
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[minPosition] > array[i])
            minPosition = i;
        if (array[maxPosition] < array[i])
            maxPosition = i;
    }
    return array[maxPosition] - array[minPosition];
}

double[] thisArray = CreateArray(new Random().Next(5, 20));
PrintArray(thisArray);
Console.WriteLine($" -> {DiffMaxMin(thisArray).ToString().Replace(',', '.')}");