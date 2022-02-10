// Задача 20. Задать номер четверти, показать диапазоны для возможных координат

int quarterPlane = new Random().Next(1, 5);
Console.WriteLine($"Случайный номер четверти: {quarterPlane}");

if (quarterPlane == 1)
    Console.WriteLine("I четверть, Диапазон возможных координат: (x>0, y>0)");
else if (quarterPlane == 2)
    Console.WriteLine("II четверть, Диапазон возможных координат: (x<0, y>0)");
else if (quarterPlane == 3)
    Console.WriteLine("III четверть, Диапазон возможных координат: (x<0, y<0)");
else if (quarterPlane == 4)
    Console.WriteLine("IV четверть, Диапазон возможных координат: (x>0, y<0)");