﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int k = 1;
while (k <= a)
{
    if (k % 2 == 0)
    {
        Console.WriteLine(k);
    }
    k++;
}