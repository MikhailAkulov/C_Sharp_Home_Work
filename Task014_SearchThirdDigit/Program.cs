// Задача 14. Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число не менее трёх цифр: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int result))
{
    string number = result.ToString();
    if (number.Length >= 3)
    {
        Console.WriteLine($"Третья цифра числа: {number[2]}");
    }
    else
    {    
        Console.WriteLine("Третьей цифры нет, может число не трёхзначное? Попробуйте ещё разок");
    }
}
else
{
    Console.WriteLine("Ввели не число");
}