/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 
*/

int iRows = ConsRead("Введите индекс строки: ");
int iColums = ConsRead("Введите индекс столбца: ");
int[,] numbers = new int[8, 8];
FillArray(numbers);
PrintArray(numbers);

if (iRows < numbers.GetLength(0) && iColums < numbers.GetLength(1))
{
    Console.WriteLine(numbers[iRows, iColums]);
}
else Console.WriteLine($"[{iRows}:{iColums}] -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ConsRead(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
