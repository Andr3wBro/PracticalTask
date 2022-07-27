string[] array = { "Moscow", "NewYork", "<3", "FBI", "UNO" };

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+"  ");
    }
    Console.WriteLine();
}

PrintArray(array);