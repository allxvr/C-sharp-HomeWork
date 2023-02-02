// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, 
// что третьей цифры нет. Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int num = new Random().Next(-900000, 999999);
Console.WriteLine($"Сгенерировали число => {num}");
// Console.Write($"Введите число: ");
// int num = Math.Abs(int.Parse(Console.ReadLine()));

// Решение без методов
// int dig = 0;
// int num2 = Math.Abs(num); //применяем модуль на случай отриц числа на входе
// while (num2 > 0)
// {
//     num2 = num2 / 10;
//     dig++;
// }
// int num3dig = 0;
// if (dig < 3)
// {
//     Console.WriteLine($"третьей цифры нет");
// }
// else
// {
//     int div = 1;
//     int a = dig;
//     while (a>3)
//     {
//         div = div*10;
//         a--;
//     }
//     num3dig = (num/div)%10;
//     }
// Console.WriteLine($"третья цифра => {num3dig}");

// Решение через методы
/*int NumOfDig = numDigits(num);
Console.WriteLine($"количество цифр в числе => {NumOfDig}");
val3DigNum(num, NumOfDig);

// Метод нахождения количества цифр в числе
int numDigits(int number)
{
    int numberMdl = Math.Abs(number);
    int dig = 0;
    while (numberMdl > 0)
    {
        numberMdl = numberMdl / 10;
        dig++;
    }
    return dig;
}
// Метод определения третьей цифры в числе
void val3DigNum(int number, int numDigs)
{
    int num3dig = 0;
    if (numDigs < 3)
    {
        Console.WriteLine($"третьей цифры нет");
    }
    else
    {
        int div = 1;
        int a = numDigs;
        while (a > 3)
        {
            div = div * 10;
            a--;
        }
        num3dig = (number / div) % 10;
        Console.WriteLine($"третья цифра => {num3dig}");
    }
}
 */

// Решение 2 с модулем в расчете 3го числа 
// if (num>-100 && num<100)
// {
//     Console.WriteLine($"третьей цифры нет");
// }
// else
// {
//     while (num<-1000 || num>1000)
//     {
//         // num/=10;
//         num = Math.Abs(num)/10;
//     }
//     int num3dig = num%10;
//     Console.WriteLine($"третья цифра => {num3dig}");
// }

// Решение 3 с числом по модулю перед ветвлением

num = Math.Abs(num); //применяем модуль на случай отриц числа на входе
if (num<100)
{
    Console.WriteLine($"третьей цифры нет");
}
else
{
    while (num>999)
    {
        num/=10;
    }
    int num3dig = num%10;
    Console.WriteLine($"третья цифра => {num3dig}");
}


