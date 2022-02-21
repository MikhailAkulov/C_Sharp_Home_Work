// Задача 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[10];

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().NextDouble() * 100;
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Массив случайных вещественных чисел: ");
    while (position < count)
    {
        Console.WriteLine(col[position] + " ");
        position++;
    }
}

void CheckingArray(double[] arr)
{
    double[] checkingArray = new double[arr.Length];
    double max = arr[0];
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max >= arr[i]) min = arr[i];
        else
            max = arr[i];
    }
    for (int j = 0; j < arr.Length; j++)
    {
        if (min > arr[j]) min = arr[j];
    }
    double difference = max - min;
    Console.WriteLine($"Максимальный элемент = {max} ");
    Console.WriteLine($"Минимальный элемент = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {difference}");
}

FillArray(array);
PrintArray(array);
CheckingArray(array);