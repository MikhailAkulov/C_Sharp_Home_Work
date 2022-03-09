// Задача 63. Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

List<int> numbers = new List<int>();
Random rand = new Random();

int GetUniqueNumber()
{
    while (true)
    {
        int n = rand.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

int[,,] array = new int[3, 5, 6];

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GetUniqueNumber();
            }
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Плоскость {i + 1}: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} [{i}, {j}, {k}] ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Трёхмерный массив:");
FillArray();
PrintArray();