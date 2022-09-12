/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

int Akkerman(int m, int n)
{
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return n + 1;
}

int M = PromptInt("Enter M > ");
int N = PromptInt("Enter N > ");
if (M > 0 && N > 0)
    System.Console.Write(Akkerman(M, N));
else
    System.Console.WriteLine("Numbers N and M must be positive");