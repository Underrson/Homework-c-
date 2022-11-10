// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.Write("Это не пятизначное число, попробуйте еще раз: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 > 9999 && num2 < 100000)
    {
        num=num2;
    }
}


  if (num/10000 == num % 10 && num/1000 % 10 == num/10 % 10)
  {
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }

  
  else 
  {
    Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
  }

