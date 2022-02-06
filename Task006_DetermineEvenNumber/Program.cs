// Выяснить является ли число чётным

int number = new Random().Next(1, 100);
Console.WriteLine("Сгенерированное число: " + number);

int remains = number % 2;

if(remains == 0)
{
    Console.WriteLine("Является чётным");
}
else
{
    Console.WriteLine("Является нечётным");
}