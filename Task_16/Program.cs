// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


Console.WriteLine("Введите число от 1 до 7, обозначающее день недели ");
int day = int.Parse(Console.ReadLine());

if (day < 6)
{
    Console.WriteLine("Будний день");
}

else
{
    if (day < 8)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Неверно введено число");
    }
}