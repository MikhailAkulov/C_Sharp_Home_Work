// Задача 61. Найти произведение двух матриц

int[,] arrayOne = new int[3, 3];
int[,] arrayTwo = new int[3, 2];
int[,] arrayResult = new int[3, 2];
Random rand = new Random();
void FillArrayOne(int[,] arrayOne)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            arrayOne[i, j] = new Random().Next(1, 10);
        }
    }
}

void FillArrayTwo(int[,] arrayTwo)
{
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayTwo[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[y, x]} ");
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int[,] arrayResult, int[,] arrayOne, int[,] arrayTwo)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                arrayResult[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }
    }
}

Console.WriteLine("Матрица №1:");
FillArrayOne(arrayOne);
PrintArray(arrayOne);
Console.WriteLine("Матрица №2:");
FillArrayTwo(arrayTwo);
PrintArray(arrayTwo);
Console.WriteLine("=============================");
Console.WriteLine("Произведение матриц:");
MultiplicationArray(arrayResult, arrayOne, arrayTwo);
PrintArray(arrayResult);