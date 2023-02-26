/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/

Console.Clear();
int m = ConsRead("Введите неотрицательных число m: ");
int n = ConsRead("Введите неотрицательных число  n: ");
Console.WriteLine($"A({m},{n}) = {Ackermann(m, n)}");

int ConsRead(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
