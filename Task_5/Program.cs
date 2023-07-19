// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Моё решение:

int[] FindProduckt(int[] array)
{
    int[] produckt = new int[array.Length];
    int ostatok = array.Length % 2;
    if (ostatok == 0)
    {
        produckt = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            produckt[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        produckt = new int[array.Length / 2 + 1];
        produckt[^1] = array[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            produckt[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return produckt;
}

int[] GenerateRandomArray(int size, int start, int finish)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] answer = GenerateRandomArray(7, 1, 5);
Console.Write($"[{String.Join(", ", answer)}]");
int[] otwet = FindProduckt(answer);
Console.Write($" -> [{String.Join(", ", otwet)}]");



