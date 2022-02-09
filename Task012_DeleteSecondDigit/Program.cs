// Задача 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int thirdDigit = number % 10;
Console.WriteLine($"Случайное трёхзначное число: {number}");
Console.WriteLine($"Число без второй цифры: {firstDigit}{thirdDigit}");