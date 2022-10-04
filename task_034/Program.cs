using Lib;
using static System.Console;

Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);

if(arraySize < 1)
{
    WriteLine("Неверно задан размер массива!");
    return;
}

int[] myArray = Arrays.CreateRandomArray(arraySize, 100, 999);
Arrays.PrintArray(myArray);
WriteLine($"Количество четных чисел в массиве = {Arrays.ArrayEvenCount(myArray)}");