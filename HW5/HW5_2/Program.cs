// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] array = CreateRandomArray(5, -100, 100);
Console.WriteLine($"{string.Join(" ", array)}");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
    {
        count += array[i];
    }

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {count}");