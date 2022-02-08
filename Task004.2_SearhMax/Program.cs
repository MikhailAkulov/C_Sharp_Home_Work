// Найти максимальное из трех чисел (Исправление замечаний)

Random randomizer = new Random();
int a = randomizer.Next(1, 100);
int b = randomizer.Next(1, 100);
int c = randomizer.Next(1, 100);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

Console.WriteLine(); // Пустая строка для отделения ответа

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);