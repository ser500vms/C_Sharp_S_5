// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int GetSumPlusOrMinus(int[] array, bool positive)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (positive)
        {
            if (array[i] > 0)
            {
                sum += array[i];
            }
        }
        else
        {
            if (array[i] < 0)
            {
                sum += array[i];
            }
        }
    }
    return sum;
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

int[] array = GenerateRandomArray(12, -9, 9);
Console.Write($"в массиве [{String.Join(", ", array)}]");
Console.WriteLine($"сумма положительных чисел равна {GetSumPlusOrMinus(array, true)}, сумма отрицательных равна {GetSumPlusOrMinus(array, false)}.");



