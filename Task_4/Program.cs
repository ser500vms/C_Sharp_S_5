// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат
//  в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении 
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int GetCount(int[] array, int numa, int numb)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > numa && array[i] < numb)
        {
            count ++; 
        }
    }
    return count;
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

int[] array = GenerateRandomArray(123, 1, 99);
Console.Write($" -> [{String.Join(", ", array)}] -> {GetCount(array, 10, 99)}");