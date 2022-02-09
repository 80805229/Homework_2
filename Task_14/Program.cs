// Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите число ");

int num = int.Parse(Console.ReadLine());

if(num<100)
{
    Console.WriteLine("Третьей цифры числа нет"); 
}
else
{
    while(num>1000)
    {
        num = num/10;   
    }

    int n1 = num%10;
    Console.WriteLine("Третья цифра числа " + n1);

}
