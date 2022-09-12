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

int SumNumbers(int start, int end)
{
    if (start < end)
        return start + SumNumbers(start + 1, end);
    else
        return start;
}

int M = PromptInt("Enter M > ");
int N = PromptInt("Enter N > ");
if (M < N)
    System.Console.Write(SumNumbers(M, N));
else
    System.Console.WriteLine("Number N must be greater than M");
