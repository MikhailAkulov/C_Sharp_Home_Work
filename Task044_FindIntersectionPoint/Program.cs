// Задача 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

Random randomNumber = new Random();

double b1 = randomNumber.Next(1, 11);
Console.WriteLine($"b1 задана = {b1}");
double k1 = randomNumber.Next(1, 11);
Console.WriteLine($"k1 задана = {k1}");
double b2 = randomNumber.Next(1, 11);
Console.WriteLine($"b2 задана = {b2}");
double k2 = randomNumber.Next(1, 11);
Console.WriteLine($"k2 задана = {k2}");

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    Console.WriteLine($"Координаты точки пересечения: x = {((b2 - b1) / (k1 - k2)):F2}, y = {(k1 * (b2 - b1) / (k1 - k2) + b1):F2}");
}