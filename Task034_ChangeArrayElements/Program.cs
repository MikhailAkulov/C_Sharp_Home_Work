// Задача 34. Написать программу замену элементов массива на противоположные

Random randomizer = new Random();
int a = randomizer.Next(1, 21);
int[] array = new int[a];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(-10,11);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position<count)
    {
        Console.Write(col[position] + " ");
        position++;
    } 
}

void ReplaceArray(int[] arr)
{
    int[] replaceArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        replaceArray[i] = arr[i]*(-1);
        Console.Write($"{replaceArray[i]} ");
    }
}

Console.Write("Массив случайных элементов: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Массив заменённых элементов: ");
ReplaceArray(array);