/* Задача 38: Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным 
элементов массива.
Пример:
[3 7 22 2 78] -> 76
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

int difMinMax(int[] NewArray)
{
    int min = NewArray[0];
    int max = NewArray[0];
    for (int i = 1; i < NewArray.Length; i++)
    {
        if (min > NewArray[i]) min = NewArray[i];
        if (max < NewArray[i]) max = NewArray [i];
    }
    return max - min;
}

int[] NewArr = CreateRandomArray(10, 1, 99);
int difMiMi = difMinMax(NewArr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:"
                 + $"\n[{String.Join(", ", NewArr)}]\nравна {difMiMi}");