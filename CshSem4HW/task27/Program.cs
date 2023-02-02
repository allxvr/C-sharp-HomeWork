/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12 
*/

int number = ConsRead("Введите число: ");
int len = numLen(number);
sumDig(number, len);


// Метод ввода в консоль
int ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод нахождения количества цифр в числе
int numLen(int number)
{
    int numberMod = Math.Abs(number);
    int dig = 0;
    if (number == 0) dig = 1;
    while (numberMod > 0)
    {
        numberMod /= 10;
        dig++;
    }
    return dig;
}

// Процедура вывода суммы цифр в числе
void sumDig (int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе {number} равно => {sum}");
}




