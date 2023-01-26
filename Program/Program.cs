
string[] InputArray()
{
    Console.WriteLine("Уточните общее количество элементов будущего массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] myArray = new string[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = Console.ReadLine()!;
    }
    return myArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] arr = InputArray();
PrintArray(arr);

int newLength = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) newLength = newLength + 1;
}

string[] newArray = new string[newLength];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        newArray[count] = arr[i];
        count++;
    }
}
PrintArray(newArray);