﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result *= numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numA, numB);
  Console.WriteLine(exponentiation);