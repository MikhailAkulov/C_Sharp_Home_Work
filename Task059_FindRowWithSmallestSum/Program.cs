// Задача 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] array = new int[5, 10];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindSumString()
{
    int sumString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString += array[i,j];
        }
        Console.WriteLine($"Сумма элементов {i} строки = {sumString}");
        sumString = 0;
    }
}

void PrintMinString()
{
    int minSumString = int.MaxValue;
    int indexMinSumString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString += array[i,j];
        }
        if (sumString < minSumString) 
        {
            minSumString = sumString;
            indexMinSumString = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMinSumString}");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[indexMinSumString, j] + " ");
    }
    Console.WriteLine();          
}

Console.WriteLine("В прямоугольной матрице вида:");
FillArray();
PrintArray();
Console.WriteLine("=============================");
FindSumString();
Console.WriteLine("=============================");
PrintMinString();