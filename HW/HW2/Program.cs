//Задача 2 (Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел).

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if (n2 > max) 
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}

Console.WriteLine("Максимальное число: " + max);
