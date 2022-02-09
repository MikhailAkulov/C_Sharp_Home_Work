// Задача 10. Показать вторую цифру трёхзначного числа. (С рандомайзером и попроще)

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число: {number}");

int secondDigit = number % 100 / 10;
Console.WriteLine($"Вторая цифра числа: {secondDigit}");