/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125  */

void CubeTable(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i < N; i++)
        Console.Write($"{i * i * i}, ");
    Console.WriteLine(N * N * N);
}

CubeTable(new Random().Next(100));