// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// вар 1, работает, но некорректно, выдает 8 и i,i,i,i

// Console.WriteLine("введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for(int i = 1; i <= n; i++)
//{
//if(i % 2 == 0) 
//{
//    Console.WriteLine("i");
//}
//}

//вариант 2, рабочий!!!

Console.WriteLine("введите число: ");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);

for(int i = 1; i <= n; i++)
{
if(i % 2 == 0) 
{
    Console.WriteLine(i.ToString());
}
}