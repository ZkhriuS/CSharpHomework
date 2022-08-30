/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */
int value = new Random().Next();
int power = 1;
while (value / power > 999) power *= 10;
if (value > 99) Console.WriteLine($"third digit of {value} is {value / power % 10}");
else Console.WriteLine($"there isn't third digit in {value}");