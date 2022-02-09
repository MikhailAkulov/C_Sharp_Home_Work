// Задача 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string inPut = String.Empty;
int number = 0;
while (number <= 0 || number >= 8)
{
    Console.Write("Введите число от 1 до 7: ");
    inPut = Console.ReadLine();
    int.TryParse(inPut, out number);
}

string[] dayOfWeek = { "Чётров Monday", "Гребаный Tuesday", "Долбаная Wednesday", "Ещё чуть-чуть, Thursday", "Слава Богу, Friday", "Ура, Saturday!", "Sunday, блин, завтра понедельник" };
//                           0                  1                   2                           3                       4               5                           6

if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} - выходной день");
}
else
{
    Console.WriteLine($"{number} - будний день");
}

Console.WriteLine(dayOfWeek[number - 1]);