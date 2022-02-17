// Задача 28. Подсчитать сумму цифр в числе

int GetNumber()
{
    int randomNumber = new Random().Next(10, 1000000);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Случайное число: {number}");

int temporary = number;
int SumOfDigits = 0;
while (temporary != 0)
{
    SumOfDigits += temporary % 10;
    temporary /= 10;
}

Console.WriteLine($"Сумма цифр случайного числа: {SumOfDigits}");
