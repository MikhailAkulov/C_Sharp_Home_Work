// Задача 24. Найти кубы чисел от 1 до N

int InPut(string message)
{
    Console.Write(message);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}

int[] InitArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}^3 = {array[i]}");
    }
}

int b = InPut("Введите число N > 1: ");

var array = InitArray(b);

PrintArray(array);