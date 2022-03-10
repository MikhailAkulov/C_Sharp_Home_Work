// Задача 65. Спирально заполнить двумерный массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

int[,] array = new int[4, 4];

void SpirallyFillArray(int endString, int endColumn, int[,] array)
{
    int value = 1;
    int startString = 0;
    int startColumn = 0;

    while (startString < endString && startColumn < endColumn)
    {
        for (int i = startColumn; i < endColumn; i++)
        {
            array[startString, i] = value++;                    // пробегаем верхнюю строку слева направо
        }
        startString++;                                          // переключаемся на следующую строку (вниз) для следующего пробега по циклу

        for (int i = startString; i < endString; i++)
        {
            array[i, endColumn - 1] = value++;                  // спускаемся по крайнему справа столбцу
        }
        endColumn--;                                            // переключаемся на предыдущий столбец (слева) для следующего пробега по циклу

        if (startString < endString)
        {
            for (int i = endColumn - 1; i >= startColumn; i--)
            {
                array[endString - 1, i] = value++;              // пробегаем нижнюю строку справа налево
            }
        }
        endString--;                                            // переключаемся на предыдущую строку (вверх) для следующего пробега по циклу

        if (startColumn < endColumn)
        {
            for (int i = endString - 1; i >= startString; i--)
            {
                array[i, startColumn] = value++;                // поднимаемся по крайнему левому столбцу
            }
        }
        startColumn++;                                          // переключаемся на следующий столбец (справа) для следующего пробега по циклу
    }
}

void PrintArray(int[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for(int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[y, x]}\t");
        }   
        Console.WriteLine();
    }
}

Console.WriteLine("Спирально заполненный двумерный массив:");
SpirallyFillArray(array.GetLength(0), array.GetLength(1), array);
PrintArray(array);