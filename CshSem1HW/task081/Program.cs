// Задача 8 
Console.Clear();
Console.WriteLine("Введите любое целое число  N :");
int n = Convert.ToInt32(Console.ReadLine());

  
// if (n>0)
// {
//     int count = 1;
//     while (count <= n)
//     {
//         if (count%2==0)
//         {
//             Console.Write(" {0,3}",count);
//         }
//         count++;
//     }
// }
// else if (n<=0)
// {
//     int count = -1;
//         while (count >= n)
//     {
//         if (count%2==0)
//         {
//             Console.Write(" {0,3}",count);
//         }
//         count--;
//     }
// }
if (n>0)
{
    Console.WriteLine("Все четные числа  от 1 до N :");
    int count = 0;
    while (count < n-1)
    {
        count=count+2; 
        Console.Write(" {0,3}",count);
    }
}
else if (n<0)
{
    Console.WriteLine("Все четные числа  от 1 до N :");
    int count = 0;
        while (count > n+1)
    {
        count=count-2; 
        Console.Write(" {0,3}",count);
    }
}
else if (n==0)
{
   Console.Write("Ошибка! Вы ввели 0"); 
}
