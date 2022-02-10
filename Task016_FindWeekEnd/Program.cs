// Задача 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string numberStr = String.Empty;
int number = 0;
while (number <= 0 || number >= 8)
{
    Console.Write("Введите число от 1 до 7: ");
    numberStr = Console.ReadLine();
    int.TryParse(numberStr, out number);
}

string[] dayOfWeek = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
//                           0            1         2         3          4          5            6

if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} - {dayOfWeek[number - 1]}: выходной день");
}
else
{
    Console.WriteLine($"{number} - {dayOfWeek[number - 1]}: будний день");
}