// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void GetProduckt(int[] size)
{
    int sum = 1;
    int[] array2 = new int[size];
    for (int i = 0; i < size; i++)
    {
        sum = array[i] * array[array.Length - 1 - i];
        array[i] = sum;
        Console.Write($" -> [{String.Join(", ", ] -> "); 
    }
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

int[] array = GenerateRandomArray(5, 1, 5);
Console.Write($" -> [{String.Join(", ", GetProduckt(array))}] -> "); 
