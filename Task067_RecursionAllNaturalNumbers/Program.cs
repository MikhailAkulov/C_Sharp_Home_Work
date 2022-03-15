// Задача 67. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Console.WriteLine("Эта программа выведет все натуральные числа в промежутке от M до N");
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

string NumbersRec(int M, int N)
{
    if (M <= N) 
    {
        return $"{M} " + NumbersRec(M + 1, N);
    }
    else 
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersRec(M, N));