/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows = ConsRead("Введите количество строк: ");
int columns = ConsRead("Введите количество столбцов: ");
int[,] FirstArray = new int[rows, columns];
int[,] SecondArray = new int[rows, columns];


FillArray(FirstArray);
PrintArray(FirstArray);

Console.WriteLine("============");

FillArray(SecondArray);
PrintArray(SecondArray);

Console.WriteLine("============");

int [,] multiplyMass = MultiArr(FirstArray,SecondArray);
PrintArray (multiplyMass);

int [,] MultiArr (int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ConsRead(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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
