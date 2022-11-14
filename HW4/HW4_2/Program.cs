// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cумм цифр = {GetSumNums(numberN)}");

  int GetSumNums (int num)
  {
    
    int sum = 0;
    while (num>0)
    {
      sum += num % 10;
      num /= 10;
    }
   return sum;
  }


