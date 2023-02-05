/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/


Console.Clear();
int a = ConsRead("Введите А: ");
int b = ConsRead("Введите B: ");
Console.Write($"Число {a} в степени {b} равно => {riseNum(a, b)}");

// Метод ввода в консоль
int ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

// // Процедура возведения в степень
// void riseNum(int x, int y)
// {
//     int num = 1;
//     for (int i = 1; i <= y; i++)
//     {
//         num *= x;
//     }
//     Console.Write($"Число {a} в степени {b} равно => {num}");
// }

// Метод возведения в степень
int riseNum(int num, int rank)
{
    if (num ==0) return 1;
    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}