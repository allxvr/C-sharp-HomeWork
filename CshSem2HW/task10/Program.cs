// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого 
// числа. Например:
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Clear();

// Решение с рандом без функций

// int num = new Random ().Next(100,1000);
// // например для числа 456 числа a b c
// int a = num / 100; //4
// int b = (num % 100)/10; //5
// int c = num % 10; //6
// Console.Write ($"У числа {num} вторым является {b} ");

//Решение методами

// Метод ввода в консоль с чтением из нее
int ConsEnter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Метод вычисления 2ой цифры в трехзначном числе
int SecondNum(int num)
{
    int result = (num / 10) % 10;
    return result;
}
// Метод вычисления 2ой цифры в трехзначном отрицательном числе
int SecondMinusNum(int num)
{
    int result = -(num / 10) % 10;
    return result;
}
// Метод определения количества цифр в числе
int NumDigits(int numb)
{
    int nDig = 0; //количество цифр
    while (numb > 0)
    {
        numb = numb / 10;
        nDig++;
    }
    return nDig;
}
//  Метод определения количества цифр в отрицательном числе
int NumMinusDigits(int numb)
{
    int nDig = 0; //количество цифр
    while (numb < 0)
    {
        numb = numb / 10;
        nDig++;
    }
    return nDig;
}

int number = ConsEnter("Введите трехзначное число: ");

// if ( number>99 && number<1000) //1ый способ определения 3х значности числа
// if ( number<-99 && number>-1000) //1ый способ определения 3х значности отриц числа

// int number_length = number.ToString().Length; //2ой способ опред колич цифр
// if (number_length < 3 || number_length > 3)

// if (number>-100 && number <-1000 )
if (number > 0)
{
    int dig = NumDigits(number);  //третий способ через метод
    if (dig == 3)
    {
        int SN = SecondNum(number);
        Console.WriteLine(SN);
        // Или короткий вывод, где обошлись без переменной
        // Console.WriteLine(SecondNum (number));
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}
else
{
    int dig = NumMinusDigits(number);
    if (dig == 3)
    {
        int SN = SecondMinusNum(number);
        Console.WriteLine(SN);
        // Или короткий вывод, где обошлись без переменной
        // Console.WriteLine(SecondNum (number));
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}