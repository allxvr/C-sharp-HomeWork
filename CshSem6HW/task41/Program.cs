/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 
*/

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToArray(Console.ReadLine());

PrintArray(numbers);

int sumZero = NumOfZero(numbers);
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sumZero}");


int[] StringToArray(string input)
{
    int commmacount = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            commmacount++;
        }
    }
    int[] numArr = new int[commmacount];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";
        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numArr[index] = Convert.ToInt32(temp);
        index++;
    }
    return numArr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
            if (i != 0 && i % 20 == 0) Console.WriteLine();
        }
    }
    Console.Write("]");
}

int NumOfZero(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}