/* Задача 1: напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */
string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

bool IsPalindrome(int number)
{
    if (number >= 0)
    {
        int temp = number, reverseNumber = 0;
        while (temp > 0)
        {
            reverseNumber = reverseNumber * 10 + temp % 10;
            temp /= 10;
        }
        return reverseNumber == number;
    }
    Console.WriteLine("Number must be non-negative!");
    return false;
}

if (int.TryParse(Prompt("Enter number > "), out int num))
{
    if (IsPalindrome(num))
        Console.WriteLine($"Number {num} IS a palindrome");
    else if (num > 0)
        Console.WriteLine($"Number {num} is NOT a palindrome");
}
else Console.WriteLine("Not a number!");