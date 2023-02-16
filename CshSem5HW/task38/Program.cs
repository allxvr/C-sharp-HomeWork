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

int DifMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    return max - min;
}

// метод с циклом foreach
int DifMinMax2(int[] array)
{
    int min = array[0];
    int max = array[0];
    
    // foreach чтобы переменная item принимала значения последовательно 
    //для каждого элемента массива
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}

int[] newArr = CreateRandomArray(10, 1, 99);
int difMiMi = DifMinMax2(newArr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:"
                 + $"\n[{String.Join(", ", newArr)}]\nравна {difMiMi}");

// Способ задания массива с дробными числами
// RandomArray[i] = new Random().Next(start, end + 1) + new Random().NextDouble();
// if (RandomArray[i] > end) RandomArray[i] = end;