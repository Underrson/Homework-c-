//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма элементов от {n} до {m} = {CountNaturalSum(n, m)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int n, int m)
{
    if (n == m)
        return m;
    return m + CountNaturalSum(n, m - 1);
}