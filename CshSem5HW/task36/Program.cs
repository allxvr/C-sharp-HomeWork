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

int SumOddNum(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

int[] newArr = CreateRandomArray(10, -10, 10);
int sumOdd = SumOddNum(newArr);
Console.WriteLine($"Сумма элементов нечетных позиций массива:"
                 +$"\n[{String.Join(", ", newArr)}]\nравна {sumOdd}");
