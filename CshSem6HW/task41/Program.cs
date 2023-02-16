/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 
String.Split
*/
Console.Clear();
string stringOfNum = ConsRead("Введите несколько чисел через пробел:");
int numElem = NumArrElem(stringOfNum);
Console.WriteLine($"кол элементов массива = {numElem}");
int [] newArray = NumStrArray(stringOfNum, numElem);
printArray(newArray);
Console.WriteLine();
OverZero(newArray);

string ConsRead(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

int NumArrElem(string numbers)
{
    char space = ' ';
    int countArr = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == space)
        {
            if (i == 0) continue;
            countArr += 1;
        }
        else if (i == numbers.Length - 1)
        {
            countArr += 1;
        }
    }
    return countArr;
}

int[] NumStrArray(string input, int elements)
{
    char space = ' ';
    string result = String.Empty;
    int[] array = new int[elements];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != space)
        {
            result = result + $"{input[i]}";
        }
        if (input[i] == space)
        {
            if (i == 0) continue;
            array[j] = Convert.ToInt32(result);
            result = String.Empty;
            j++;
        }
        else if (i == input.Length - 1)
        {
            array[j] = Convert.ToInt32(result);
            result = String.Empty;
            break;
        }
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
            if (i != 0 && i % 18 == 0) Console.WriteLine();
        }
    }
    Console.Write("]");
}

void OverZero(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine($"Кол-во чисел больше '0' -> {sum}");
}


/*Console.Write("Введите числа через запятую: ");
int[] numbers = StringToArray(Console.ReadLine());

PrintArray(numbers);

int sumZero = NumOfZero(numbers);
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sumZero}");

int[] StringToArray(string input)
{
    int commacount = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            commacount++;
        }
    }
    int[] numArr = new int[commacount];
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
} */


