string[] CreateArray(string[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            count++;
        }
    }
    string[] NewArray = new string[count];
    int n = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            NewArray[n] = myArray[i];
            n++;
        }
    }
    return NewArray;
}
void PrintArray(string[] myArray)
{
    Console.Write("[");
    for (int i = 0; i < myArray.Length - 1; i++)
    {
        Console.Write($"{myArray[i]}, ");
    }
    Console.Write($"{myArray[myArray.Length - 1]}]");
}

string[] array = { "1284", "the", "77", "print", "A" };
PrintArray(CreateArray(array));
