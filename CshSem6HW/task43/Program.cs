/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();

double b1 = ConsRead("введите значение b1: ");
double k1 = ConsRead("введите число k1: ");
double b2 = ConsRead("введите значение b2: ");
double k2 = ConsRead("введите число k2: ");

CrossLines(b1, k1, b2, k2);

double ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

void CrossLines(double x1, double y1, double x2, double y2)
{
    double crossX = (x2 - x1) / (y1 - y2);
    double crossY = y2 * crossX + x2;
    Console.WriteLine($"точка пересечения двух прямых ({crossX}, {crossY})");
}