/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве.
Пример:
[345, 897, 568, 234] -> 2 
*/
Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int evenNum(int[] NewArray)
{
    int sumEven = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i] % 2 == 0) sumEven++;
    }
    return sumEven;
}

int[] NewArr = CreateRandomArray(10, 100, 999);
int numEvenNum = evenNum(NewArr);
Console.WriteLine($"Количество четных чисел в массиве: \n[{String.Join(", ", NewArr)}]"
                 +$"\nравно {numEvenNum}");
