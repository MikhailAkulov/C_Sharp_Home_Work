// Задача 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] array = new int[6,8];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void ChangeEvenElements()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * -1;
            }
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первоначальный вид массива:");
FillArray();
PrintArray();
Console.WriteLine("Массив с чётными элементами измененными на нечётные:");
ChangeEvenElements();