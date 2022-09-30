/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int PromptInt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int input))
        return input;
    return -1;
}

int[,] CreateMatrix()
{
    int rows = PromptInt("Enter number of rows > ");
    int columns = PromptInt("Enter number of columns > ");
    if (rows > 0 && columns > 0)
    {
        int[,] array = new int[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-10, 10);
            }
        }
        return array;
    }
    return null;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Multiply(int[,] A, int[,] B)
{
    if (A.GetLength(1) == B.GetLength(0))
    {
        int[,] C = new int[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < C.GetLength(0); i++)
            for (int j = 0; j < C.GetLength(1); j++)
                for (int k = 0; k < A.GetLength(1); k++)
                    C[i, j] += A[i, k] * B[k, j];
        return C;
    }
    System.Console.WriteLine("Can't multiply matrixes");
    return null;
}

System.Console.WriteLine("\tMatrix A");
int[,] matrixA = CreateMatrix();
if (matrixA != null)
{
    PrintMatrix(matrixA);
    System.Console.WriteLine("\n\tMatrix B");
    int[,] matrixB = CreateMatrix();
    if (matrixB != null)
    {
        PrintMatrix(matrixB);
        int[,] matrixC = Multiply(matrixA, matrixB);
        if (matrixC != null)
        {
            System.Console.WriteLine("\nA X B = ");
            PrintMatrix(matrixC);
        }
    }
}
