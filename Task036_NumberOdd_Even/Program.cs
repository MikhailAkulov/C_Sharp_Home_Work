// Задача 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Random randomizer = new Random();
int a = randomizer.Next(10, 101);
int[] array = new int[a];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}


void CheckingArray(int[] arr)
{
    int[] checkingArray = new int[arr.Length];
    int even = 0;
    int odd = 0;
    int index = 0;
    while (index < arr.Length)
    {
        if (arr[index] % 2 == 0)
        {
            even++;
        }
        else
        {
            odd++;
        }
        index++;
    }
    Console.WriteLine($"Всего элементов в массиве: {index}. Из них: ");
    Console.WriteLine($"Четных: {even} ");
    Console.WriteLine($"Нечетных: {odd} ");
}

Console.WriteLine("Массив случайных трёхзначных чисел: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
CheckingArray(array);