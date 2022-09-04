/* Задача 5 *: Напишите программу, которая генерирует несколько случайных чисел,
и в цикле проверяет, кратны ли эти числа предварительно введенному числу, 
при кратности - цикл прерывается.
Введенное число 2
13 -> нет
15 -> нет
12 -> да  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

void CheckMultyplicity(int value)
{
    Console.WriteLine($"Number is {value}");
    while (true)
    {
        int temp = new Random().Next(minValue: value, value * 1000);
        if (temp % value == 0)
        {
            Console.WriteLine($"{temp} -> yes");
            return;
        }
        Console.WriteLine($"{temp} -> no");
    }
}

if (int.TryParse(Prompt("Enter positive number > "),
            out int myNumber))
{
    if (myNumber > 0) CheckMultyplicity(myNumber);
    else Console.WriteLine("Number must be positive!");
}
else Console.WriteLine("Not a number!");
