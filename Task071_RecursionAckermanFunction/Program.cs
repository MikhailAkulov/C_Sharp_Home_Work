// Задача 71. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Эта программа вычисляет функцию Аккермана");
int m = CheckInputIsNumber("введите положительное число m: ");
int n = CheckInputIsNumber("введите положительное число n: ");

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

int AckermanRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermanRec(m - 1, 1);
    }
    else
    {
        return AckermanRec(m - 1, AckermanRec(m, n - 1));
    }
}

Console.WriteLine($"Функция Аккермана = {AckermanRec(m, n)}");