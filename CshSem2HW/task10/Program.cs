/*Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. Например:
456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadInt("Введите трехзначное число: ");
int number_length = number.ToString().Length;

if (number_length < 3 || number_length > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}



// ФУНКЦИИ

/* Функция принимает сообщение для отображения в консоли, 
и выводит результат введенных данных пользователем.
*/ 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначного числа.
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}
