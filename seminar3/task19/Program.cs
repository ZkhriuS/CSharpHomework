/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */
bool IsPalindrome5(int number)
{
    string str = number.ToString();
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
            return false;
    }
    return true;
}

int num = new Random().Next(10000, 100000);
if (IsPalindrome5(num))
    Console.WriteLine($"Number {num} IS a palindrome");
else
    Console.WriteLine($"Number {num} is NOT a palindrome");