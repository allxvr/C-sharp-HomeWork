/* Задача 8: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа от 1 до N. Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число N ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=0){
    int i = 0;
    while (i < (a-1)){
        i = i + 2;
        Console.WriteLine(i);
    }    
} 
else {
    int i = 0;
    while (i > (a+1)){
        i = i - 2;
        Console.WriteLine(i);
    }
}