﻿//Задача 4 (Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N).

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < N)
{
    i += 2;
    Console.WriteLine(i + " ");
}
