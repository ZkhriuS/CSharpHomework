/* Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

//решение с рекурсией
int SumNumbersRecurse(int start, int end)
{
    if (start < end)
        return start + SumNumbersRecurse(start + 1, end);
    else
        return start;
}

//решение без рекурсии
int SumNumbers(int start, int end)
{
    return (start + end) * (end - start + 1) / 2;
}

int M = PromptInt("Enter M > ");
int N = PromptInt("Enter N > ");
if (M < N && M > 0)
    System.Console.Write(SumNumbersRecurse(M, N)); //System.Console.Write(SumNumbers(M, N));
else
    System.Console.WriteLine("Natural number N must be greater than natural number M");
