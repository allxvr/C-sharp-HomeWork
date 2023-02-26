/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int m = ConsRead("Введите M: ");
int n = ConsRead("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {SpanNaturalSum(m, n)}");

int ConsRead(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SpanNaturalSum(int firstNum, int lastNum)
{
    if (firstNum == lastNum) return lastNum;
    return lastNum + SpanNaturalSum(firstNum, lastNum - 1);
}