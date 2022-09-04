/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным. */
int value = new Random().Next(1, 8);
Console.Write(value);
if (value < 6) Console.WriteLine(" -> no");
else Console.WriteLine(" -> yes");