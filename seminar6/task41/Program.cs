/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int CountPositive(int[] values)
{
    int count = 0;
    for (int i = 0; i < values.Length; i++)
        if (values[i] > 0)
            count++;
    return count;
}

int[] SetArray(int size)
{
    if (size > 0)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            if (!int.TryParse(Prompt($"Enter value[{i}]: "), out array[i]))
            {
                Console.WriteLine("Not a number!");
                return null;
            }
        }
        return array;
    }
    Console.WriteLine("Can't create array!");
    return null;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

if (int.TryParse(Prompt("Enter count of values: "), out int M))
{
    int[] thisArray = SetArray(M);
    if (thisArray != null)
    {
        PrintArray(thisArray);
        Console.WriteLine($"-> {CountPositive(thisArray)} positive numbers");
    }
}
else Console.WriteLine("Not a number!");
