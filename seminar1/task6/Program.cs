/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет  */
Console.Write("Enter a value> ");
if (int.TryParse(Console.ReadLine(), out int first))
{
    if (first % 2 == 0) Console.WriteLine(" -> Yes!");
    else Console.WriteLine(" -> No!");
}
else
{
    Console.WriteLine("Incorrect input");
}

