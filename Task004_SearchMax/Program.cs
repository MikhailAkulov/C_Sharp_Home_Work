// Найти максимальное из трех чисел

int a = new Random().Next(1, 100);
Console.WriteLine(a);
int b = new Random().Next(1, 100);
Console.WriteLine(b);
int c = new Random().Next(1, 100);
Console.WriteLine(c);

Console.WriteLine(); // Пустая строка для отделения ответа

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);