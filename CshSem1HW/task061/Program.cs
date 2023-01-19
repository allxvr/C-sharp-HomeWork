Console.Clear();
Console.Write("Введите число: ");

Thread.Sleep(2000);
// int a = Convert.ToInt32(Console.ReadLine());
// string text = Console.ReadLine();
int a;
while(!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Ошибка");
    return;
}

Console.WriteLine("Проверим, является ли оно четным ... ");
Thread.Sleep(2000);

if (a % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
{
    Console.WriteLine("Число нечетное!");
}