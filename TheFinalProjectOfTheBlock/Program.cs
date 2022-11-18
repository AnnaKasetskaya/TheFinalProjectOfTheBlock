string[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] RandomArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        RandomArray[i] = Console.ReadLine();
    }
    return RandomArray;
}


void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int GetArrayLength(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) length++;
    }
    return length;
}


string[] FindArrayElementsWithLengthLessFour(string[] array)
{
    int newArrayLen = GetArrayLength(array);
    string[] newArray = new string[newArrayLen];
    if (newArrayLen > 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }
    return newArray;
}

string[] array = CreateArray();
ShowArray(array);
Console.WriteLine();
ShowArray(FindArrayElementsWithLengthLessFour(array));