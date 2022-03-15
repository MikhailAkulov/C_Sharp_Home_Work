// Задача 69. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

Console.WriteLine("Эта программа выведет сумму натуральных элементов в промежутке от M до N");
int M = CheckInputIsNumber("введите число M: ");
int N = CheckInputIsNumber("введите число N: ");
//int count = 0;

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

string SumRec(int M, int N, int count = 0)
{
    /*if (M > N)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    if (M == N) return M;
    else return M + SummRecurse(M + 1, N);*/

    if (M <= N)
    {
        return SumRec(M, N, count++);
    }
    else 
    {
        return String.Empty;
    }
}

Console.WriteLine($"Сумма элементов от {M} до {N} равна - {SumRec(M, N, count)}");