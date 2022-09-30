/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

void PrintNumbers(int N)
{
    if (N == 1)
        System.Console.Write($"{N}");
    else
    {
        System.Console.Write($"{N}, ");
        PrintNumbers(N - 1);
    }
}

int number = PromptInt("Enter number > ");
if (number > 0)
    PrintNumbers(number);
else
    System.Console.WriteLine("Number must be greater than 0");