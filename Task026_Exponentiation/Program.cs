// Задача 26. Возведите число А в натуральную степень B используя цикл

bool result = true;
string numberStrA = string.Empty;
string numberStrB = string.Empty;
double numberA = 0;
double numberB = 0;

while (numberA <= 0)
{
    Console.Write("Введите число A (которое необходимо возвести в степень): ");
    numberStrA = Console.ReadLine();
    result = double.TryParse(numberStrA, out numberA);
}

while (numberB <= 0)
{
    Console.Write("Введите число B (степень, в которую необходимо возвести число): ");
    numberStrB = Console.ReadLine();
    result = double.TryParse(numberStrB, out numberB);
}

double exponentiation = 1;

for (int i = 0; i < numberB; i++)
{
    exponentiation *= numberA;
}

Console.WriteLine($"{numberA}^{numberB} = {exponentiation}");