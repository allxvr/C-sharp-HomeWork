// Задача 15: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным. Например:
// 6 -> да 
// 7 -> да 
// 1 -> нет
Console.Clear();

// Решение без методов
// Console.Write("Введите число: ");
// int numDay = Convert.ToInt32(Console.ReadLine());
// if (numDay <= 7 && numDay >= 1)
// {
//     if (numDay > 5)
//     {
//         Console.WriteLine("ДА");
//     }
//     else
//     {
//         Console.WriteLine("НЕТ");
//     }
// }
// else
// {
//     Console.Write("Вы ввели не день недели, а что-то другое!");
// }

// Решение с методами
int numDay = EntToCons("Введите число соответствующее дню недели: ");
numWeekDay(numDay);



// Метод ввода
int EntToCons(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}
// Метод определения дня недели
void numWeekDay(int numOfDay)
{
    if (numOfDay <= 7 && numOfDay >= 1)
    {
        if (numOfDay > 5)
        {
            Console.WriteLine("Да это же выходной, гуляем!");
        }
        else
        {
            Console.WriteLine("Это серый будний денёк, чтож работаем дальше...");
        }
    }
    else
    {
        Console.Write("Вы ввели не день недели, а что-то другое!");
    }
}