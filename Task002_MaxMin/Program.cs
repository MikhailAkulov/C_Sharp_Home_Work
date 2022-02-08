// Даны два числа. Показать большее и меньшее число

int numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);

Console.WriteLine(); // Пустая строка для отделения ответа

int max = numberA;
int min = numberB;
if (numberB > numberA) max = numberB;
{
    Console.Write("Большее число = ");
    Console.WriteLine(max);
}
if (numberA < numberB) min = numberA;
{
    Console.Write("Меньшее число = ");
    Console.WriteLine(min);
}