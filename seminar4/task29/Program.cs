/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

int[] CreateAndPrintArray()
{
    Console.Write("Enter number of elements: ");
    if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
    {
        int[] array = new int[count];
        Console.Write(" -> [");
        for (int i = 0; i < count; i++)
        {
            array[i] = new Random().Next(-100, 100);
            if (i == count - 1)
                Console.Write($"{array[i]}]");
            else Console.Write($"{array[i]}, ");
        }
        return array;
    }
    else Console.WriteLine("Array doesn't contain elements");
    return null;
}

int[] arr = CreateAndPrintArray();