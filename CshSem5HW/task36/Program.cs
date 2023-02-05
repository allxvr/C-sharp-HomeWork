/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
Пример:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int sumOddNum(int[] NewArray)
{
    int sumOdd = 0;
    for (int i = 1; i < NewArray.Length; i += 2)
    {
        sumOdd += NewArray[i];
    }
    return sumOdd;
}

int[] NewArr = CreateRandomArray(10, 0, 1);
int sumOdd = sumOddNum(NewArr);
Console.WriteLine($"Сумма элементов нечетных позиций массива:"
                 +$"\n[{String.Join(", ", NewArr)}]\nравна {sumOdd}");
