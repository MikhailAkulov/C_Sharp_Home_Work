// Задача 24. Найти кубы чисел от 1 до N

Console.Write("Введите число N: ");
string? numN = Console.ReadLine();
int number = int.Parse(numN);
int min = 1;
while (min < number)
{
    if (min > 0)
        Console.Write(((min+1) * (min+1) * (min+1)) + " ");
    min++;
}
if (number < 0)
    Console.Write("Ввели отрицательное число, попробуйте ещё разок");