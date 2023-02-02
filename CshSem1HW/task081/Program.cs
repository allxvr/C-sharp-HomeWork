/* Задача 8 Задача 8: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа от 1 до N. Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.WriteLine("Введите любое целое число  N :");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("Все четные положительные числа  от 1 до N :");
    int count = 0;
    while (count < n - 1)
    {
        count = count + 2;
        Console.Write(" {0,3}", count);
    }
}
else if (n < 0)
{
    Console.WriteLine("Все четные положительные числа  от 1 до N :");
    int count = 0;
    while (count > n + 1)
    {
        count = count - 2;
        Console.Write(" {0,3}", count);
    }
}
else if (n == 0)
{
    Console.Write("Ошибка! Вы ввели 0");
}
