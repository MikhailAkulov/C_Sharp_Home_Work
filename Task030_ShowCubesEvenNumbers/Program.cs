// Задача 30. Показать кубы чисел, заканчивающихся на четную цифру

bool result = true;
string s = string.Empty;
double number = 0;

while (number <= 0)
{
    Console.Write("Введите число > 1: ");
    s = Console.ReadLine();
    result = double.TryParse(s, out number);
}

for (double i = 0; i <= number; i++)
{
    double cube = Math.Pow(i, 3);
    double even = cube % 10;

    if (even % 2 == 0 && even != 0)
    {
        Console.WriteLine($"{i}^3 = {cube}");
    }
}