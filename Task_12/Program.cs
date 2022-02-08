// Удалить вторую цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число ");

int num = int.Parse(Console.ReadLine());

int n1 = num / 100;
int n2 = num % 10;

Console.Write("Результат " );
Console.Write(n1);
Console.Write(n2);
