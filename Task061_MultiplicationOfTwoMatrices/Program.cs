// Задача 61. Найти произведение двух матриц

int a = CheckInputIsNumber("введите количество строк первой матрицы: ");
int b = CheckInputIsNumber("введите количество столбцов первой матрицы: ");
int[,] arrayOne = new int[a, b];
int c = CheckInputIsNumber("введите количество строк второй матрицы:");
int d = CheckInputIsNumber("введите количество столбцов второй матрицы: ");
int[,] arrayTwo = new int[c, d];
int[,] arrayResult = new int[a, d];
Random rand = new Random();

if (b != c)
    Console.WriteLine("Для умножения матриц необходимо чтобы число столбцов первой матрицы было равно числу строк второй матрицы");
else
{
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
}

int CheckInputIsNumber(string text)
{
    int number;
    Console.Write(text);
    string? input = Console.ReadLine();
    bool isNum = int.TryParse(input, out number);

    while (!isNum || number <= 0)
    {
        Console.Write($"Нужно число > 0, ещё разок {text}: ");
        input = Console.ReadLine();
        isNum = int.TryParse(input, out number);
    }
    return number;
}

void FillArrayOne(int[,] arrayOne)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            arrayOne[i, j] = rand.Next(1, 10);
        }
    }
}

void FillArrayTwo(int[,] arrayTwo)
{
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayTwo[i, j] = rand.Next(1, 10);
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