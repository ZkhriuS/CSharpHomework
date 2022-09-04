/* Задача 2: напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int[] SetPoint3(int[] point, char pointName)
{
    Console.WriteLine($"Enter coordinates of {pointName} > ");
    for (int i = 0; i < 3; i++)
    {
        if (!int.TryParse(Prompt($"\tEnter {(char)('X' + i)}-coordinate > "),
                    out point[i]))
        {
            Console.Write($"\tWrong coordinates of {pointName}");
            return null;
        }
    }
    return point;
}

double Distance3(int[] firstPoint, int[] secondPoint)
{
    int SqrsDelta = 0;
    for (int i = 0; i < 3; i++)
    {
        SqrsDelta += (firstPoint[i] - secondPoint[i]) * (firstPoint[i] - secondPoint[i]);
    }
    return Math.Sqrt(SqrsDelta);
}

string PrintPoint3(int[] point)
{
    return $"({point[0]}, {point[1]}, {point[2]})";
}

int[] A = SetPoint3(new int[3], 'A');
if (A != null)
{
    int[] B = SetPoint3(new int[3], 'B');
    if (B != null)
        Console.WriteLine($"Distance between {PrintPoint3(A)} and {PrintPoint3(B)} is {Distance3(A, B):f2}");
}
