// Задача 10. Показать вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное число число: ");

string valueStr = Console.ReadLine();

if (int.TryParse(valueStr, out int valueInt))
{
    string resultValue = valueInt.ToString();
    if(resultValue.Length == 3)
        Console.WriteLine($"Вторая цифра числа: {resultValue[1]}");
    else
        Console.WriteLine("Число не трёхзначное");
}
else
    Console.WriteLine("Ввели не число");