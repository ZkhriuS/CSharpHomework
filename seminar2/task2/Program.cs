int RemoveSecondIn3()
{
    int value = new Random().Next(100, 1000);
    Console.Write($"{value} -> ");
    return value / 100 * 10 + value % 10;
}

Console.WriteLine(RemoveSecondIn3());