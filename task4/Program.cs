﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1; 

for(int i = 1; i <= N; i++;)
{
if(i % 2 == 0) 
{
    Console.WriteLine("i");
}
}
// выдает ошибку в синтаксисе, но я не понимаю что исправить