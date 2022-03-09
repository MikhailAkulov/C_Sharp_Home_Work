// Задача 54. В матрице чисел найти сумму элементов главной диагонали

int[,] array = new int[6, 6];
int sum = 0;
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Заданная матрица чисел:");
FillArray();
PrintArray();
Console.WriteLine($"Сумма главной диагонали матрицы = {sum}");