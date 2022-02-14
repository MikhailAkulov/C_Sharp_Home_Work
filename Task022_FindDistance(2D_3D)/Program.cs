// Задача 22. Найти расстояние между точками в пространстве 2D/3D

string space = String.Empty;

while (space.ToLower() != "2d" || space.ToLower() != "3d")
{
    Console.WriteLine("Укажите 2D или 3D пространство для расчёта расстояния между точками: ");
    space = Console.ReadLine();
    if (space.ToLower() == "2d" || space.ToLower() == "3d")
        break;
}

double GetPoint()
{
    Console.Write("Введите координаты точки: ");
    string? numberStr = Console.ReadLine();
    double number = int.Parse(numberStr);
    return number;
}

if (space.ToLower() == "2d")
{
    double x1 = GetPoint();
    double y1 = GetPoint();
    Console.WriteLine($"Координаты первой точки (x, y): ({x1}, {y1})");
        
    double x2 = GetPoint();
    double y2 = GetPoint();
    Console.WriteLine($"Координаты второй точки (x, y): ({x2}, {y2})");

    double distance2D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine($"Расстояние между точками: {distance2D}");
}
if (space.ToLower() == "3d")
{
    double x1 = GetPoint();
    double y1 = GetPoint();
    double z1 = GetPoint();
    Console.WriteLine($"Координаты первой точки (x, y, z): ({x1},{y1},{z1})");
        
    double x2 = GetPoint();
    double y2 = GetPoint();
    double z2 = GetPoint();
    Console.WriteLine($"Координаты второй точки (x, y, z): ({x2},{y2},{z2})");

    double distance3D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние между точками: {distance3D}");
}