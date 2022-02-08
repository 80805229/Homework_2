// Показать вторую цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число ");

int num = int.Parse(Console.ReadLine());

int n = num % 100;
int a = n / 10;

Console.WriteLine("Вторая цифра трехзначного числа - " + a);

