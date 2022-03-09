// Задача 48. Показать двумерный массив размером m×n заполненный целыми числами

Console.Clear();

bool result = true;
string numberStrM = string.Empty;
string numberStrN = string.Empty;
int numberM = 0;
int numberN = 0;

while (numberM <= 0)
{
    Console.Write("Введите количество строк массива: ");
    numberStrM = Console.ReadLine();
    result = int.TryParse(numberStrM, out numberM);
}

while (numberN <= 0)
{
    Console.Write("Введите количество столбцов массива: ");
    numberStrN = Console.ReadLine();
    result = int.TryParse(numberStrN, out numberN);
}

int[,] array = new int[numberM, numberN];
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Двумерный массив по заданным параметрам:");
FillArray();
PrintArray();