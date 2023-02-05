/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
Например:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] 
*/
Console.Clear();
int min = ConsRead("Введите минимальное число массива: ");
int max = ConsRead("Введите минимальное число массива: ");
int[] array = randArr(8, min, max);
Console.WriteLine($"{String.Join(", ", array)} -> [ {String.Join(", ", array)} ] ");

// Функция формирования массива из N элементов, с мин и макс числом значения в ячейке
int[] randArr(int size, int minNum, int maxNum)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
        // Console.Write(arr[i] + " ");
    }
    return arr;
        Console.Write($" -> ");
}

// Метод ввода в консоль
int ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}
