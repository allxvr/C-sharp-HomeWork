/*Задача 19. Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. Например:
14212 -> нет
12821 -> да
23432 -> да
*/


Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это число палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - это число не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - число не является пятизначным");
}

// Альт решение с возможностью исправления
/* Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.Write("Вы ввели не пятизначное число, исправьте: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 > 9999 && num2 < 100000)
    {
        num = num2;
    }
}
if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
{
    Console.WriteLine($"Число {num} - это число палиндром");
}
else
{
    Console.WriteLine($"Число {num} - не является палиндромом");
}
 */