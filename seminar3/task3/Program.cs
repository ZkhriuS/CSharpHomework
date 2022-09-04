/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

void CubeTable(int N)
{
    if (N > 0)
    {
        Console.WriteLine("________________");
        for (int i = 1; i <= N; i++)
            Console.WriteLine($"|{i}\t|{i * i * i}\t|");
        Console.WriteLine("|_______|_______|");
    }
    else Console.WriteLine("Number must be positive!");
}

if (int.TryParse(Prompt("Enter positive integer number > "), out int number))
    CubeTable(number);
else Console.WriteLine("Not a number!");