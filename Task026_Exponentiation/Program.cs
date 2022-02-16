// Задача 26. Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число A (которое необходимо возвести в степень): ");
string? numberStrA = Console.ReadLine();
Console.Write("Введите число B (степень, в которую необходимо возвести число): ");
string? numberStrB = Console.ReadLine();

double numberA = int.Parse(numberStrA);
double numberB = int.Parse(numberStrB);

double result = 1;

for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}

Console.WriteLine($"{numberA}^{numberB} = {result}");