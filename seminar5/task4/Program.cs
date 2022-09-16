/* Задача со звездочкой: Заполнить массив четной длины таким образом, чтобы значение элемента массива повторялось ровно 2 раза.
1,1,2,3,3,2,4,5,4,5
или
1,1,2,2,4,4,5,5
или
1,2,3,3,2,1 */

const int MIN_VALUE = 0;
const int MAX_VALUE = 10;

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? string.Empty;
}

int[] CreateArray(int length, bool unique, int minValue = MIN_VALUE, int maxValue = MAX_VALUE)
{
    int[] array = new int[length];
    if (unique && maxValue - minValue < length) return null;
    for (int i = 0; i < length; i++)
    {
        int temp = new Random().Next(minValue, maxValue);
        if (unique && !IsUnique(array, temp))
        {
            i--;
            continue;
        }
        array[i] = temp;
    }
    return array;
}

bool IsUnique(int[] array, int element)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == element)
            return false;
    }
    return true;
}

int[] CreateArrayOfClones(int[] sourceArray)
{
    if (sourceArray != null)
    {
        int[] resultArray = new int[sourceArray.Length * 2];
        int[] positions = CreateArray(resultArray.Length, true, maxValue: resultArray.Length);
        for (int i = 0; i < sourceArray.Length; i++)
        {
            resultArray[positions[2 * i]] = sourceArray[i];
            resultArray[positions[2 * i + 1]] = sourceArray[i];
        }
        return resultArray;
    }
    return null;
}

void PrintArray(int[] array)
{
    if (array == null)
    {
        Console.WriteLine("Array with source parametres wasn't created");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

if (int.TryParse(Prompt("Enter length of array > "), out int size) && size > 0)
{
    if (size % 2 == 0)
        PrintArray(CreateArrayOfClones(CreateArray(size / 2, true)));
    else
        Console.WriteLine("Array with source parametres wasn't created");

}
else
    Console.WriteLine("Array doesn't contain elements");
