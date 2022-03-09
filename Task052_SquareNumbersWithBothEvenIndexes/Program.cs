// Задача 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

double[,] array = new double[6, 8];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(4, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SquareElementsWith2EvenIndexes()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = Math.Pow(array[i, j], 2);
            }
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первоначальный вид массива:");
FillArray();
PrintArray();
Console.WriteLine("Массив в котором элементы у которых оба индекса четные, возведены в квардат:");
SquareElementsWith2EvenIndexes();