/* Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int rows = ConsRead("Введите кол-во строк: ");
int colums = ConsRead("Введите кол-во столбцов: ");
// int rows = 3;
// int colums = 4;
int[,] numArray = new int[rows, colums];
FillArray2D(numArray);
PrintArray2D(numArray);

double[] numAverage = new double[numArray.GetLength(1)];
for (int i = 0; i < numArray.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numArray.GetLength(0); j++)
    {
        result += numArray[j, i];
    }
    numAverage[i] = result / numArray.GetLength(0);
}
PrintArray(numAverage);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f1}\t");
    }
    Console.WriteLine();
}

int ConsRead(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}