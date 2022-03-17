// Задача 69. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

Console.WriteLine("Эта программа выведет сумму натуральных элементов в промежутке от M до N");
int M = CheckInputIsNumber("введите число M: ");
int N = CheckInputIsNumber("введите число N: ");

int CheckInputIsNumber(string text)
{
    int number;
    Console.Write(text);
    string? input = Console.ReadLine();
    bool isNum = int.TryParse(input, out number);

    while (!isNum || number <= 0)
    {
        Console.Write($"Нужно число > 0, ещё разок {text}");
        input = Console.ReadLine();
        isNum = int.TryParse(input, out number);
    }
    return number;
}

void SumRec(int M, int N, int sum)
{
    if (M != N)
    {
        sum++;
        M++;
        SumRec(M, N, sum);
    }
    else
    {
        sum++;
        Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum}");
    }
}
if (M < N)
{
    SumRec(M, N, 0);
}
else
{
    SumRec(M, N, 0);
}