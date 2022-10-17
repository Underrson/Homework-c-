//Задача 1 (Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее).

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n > n1)
{
    Console.WriteLine("Больше число: " + n);
    Console.WriteLine("Меньшее число: " + n1);
}
else
{
    Console.WriteLine("Большее число: " + n1);
    Console.WriteLine("Меньшее число: " + n);
}
