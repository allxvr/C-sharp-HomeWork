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

int EvenNum(int[] array)
{
    int sumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sumEven++;
    }
    return sumEven;
}

// метод с циклом foreach чтобы переменная item принимала значения последовательно 
//для каждого элемента массива
int EvenNum2 (int[] array)
{
    int count=0;
    foreach (var item in array)
    {
        if (item%2==0) count++;
    }
    return count;
}

int[] newArr = CreateRandomArray(10, 100, 999);
int numEvenNum = EvenNum(newArr);
Console.WriteLine($"Количество четных чисел в массиве: \n[{String.Join(", ", newArr)}]"
                 +$"\nравно {numEvenNum}");
