/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12 
*/

int num = ConsRead("Введите число: ");
sumDigNum (num);
// int len = numLen(num);
// sumDig(num, len);


// Метод ввода в консоль
int ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод нахождения суммы чисел в числе
void sumDigNum (int number)
{
    int n = Math.Abs(number);
    int digSum = 0;
    while (n>0)
    {
        digSum +=n%10;
        n/=10;
    }
    Console.WriteLine($"Сумма цифр в числе {number} равно => {digSum}");
}

/* // Метод нахождения количества цифр в числе
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
    Console.WriteLine($"Сумма цифр в числе {num} равно => {sum}");
} */
