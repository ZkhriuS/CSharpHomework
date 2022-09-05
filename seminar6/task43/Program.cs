/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

double[] SetLine(int n)
{
    Console.WriteLine($"Enter line{n}");
    if (double.TryParse(Prompt($"Enter k{n} > "), out double k))
        if (double.TryParse(Prompt($"Enter b{n} > "), out double b))
            return new double[2] { k, b };
    Console.WriteLine("Not a number!");
    return null;
}

void PrintEquation(double[] equation)
{
    Console.WriteLine($"y = {equation[0]} * x + {equation[1]}");
}

double Xentersect(double[] equation1, double[] equation2)
{
    return (equation1[1] - equation2[1]) / (equation2[0] - equation1[0]);
}

double Yentersect(double[] equation1, double[] equation2)
{
    return (equation2[0] * equation1[1] - equation1[0] * equation2[1]) / (equation2[0] - equation1[0]);
}

double[] line1 = SetLine(1);
if (line1 != null)
{
    double[] line2 = SetLine(2);
    if (line2 != null)
    {
        PrintEquation(line1);
        PrintEquation(line2);
        Console.WriteLine($"Solution: ({Xentersect(line1, line2)}; {Yentersect(line1, line2)})");
    }
}