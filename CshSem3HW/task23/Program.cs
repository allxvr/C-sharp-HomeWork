/*Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int number = ReadInt("Введите число N: ");

int i = 1;
while (i <= number)
{ 
    // Console.Write($"{i*i*i} \t ");
    // if (i%5 == 0) Console.WriteLine();
    int x = i*i*i;
    Console.Write("{0,10}\t|", x);
    if (i%5 == 0) Console.WriteLine();
    i++;
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}