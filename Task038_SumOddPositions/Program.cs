// Задача 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Random randomizer = new Random();
int a = randomizer.Next(5, 11);
int[] array = new int[a];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 11);
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
    int sumOddPositions = 0;
    int index = 1;
    while (index < arr.Length)
    {
        sumOddPositions += arr[index];
        index = index + 2;
    }
    Console.Write($"Cумма чисел на нечётных позициях массива = {sumOddPositions}");
}

Console.Write("Массив случайных чисел: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
CheckingArray(array);