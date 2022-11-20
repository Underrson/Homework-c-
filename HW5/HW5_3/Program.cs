// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] array = CreateRandomArray(10, -100, 100);
Console.WriteLine($"{string.Join(" ", array)}");

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
    if (array[i] > max)
    {
        max = array[i];
    }
    else
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
int diff = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");