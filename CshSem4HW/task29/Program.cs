/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
Например:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] 
*/

int lenArr = ConsRead("Введите длину массива: ");

int[] randArr = new int[lenArr];
for (int i = 0; i < randArr.Length; i++)
{
    randArr[i] = new Random().Next(1,9);
    Console.Write(randArr[i] + " ");
}


// Метод ввода в консоль
int ConsRead(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}




