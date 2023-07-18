// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FindNum(int[] array, int num)
{
    string text = $"массив [{String.Join(", ", array)}] -> нет";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            text = $"массив [{String.Join(", ", array)}] -> да";
            break;
        }
    }
    Console.WriteLine($"{text}");
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

int[] array = GenerateRandomArray(8, 1, 8);
FindNum(array, 5);

