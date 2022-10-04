using Lib;
using static System.Console;

Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);

if(arraySize < 1)
{
    WriteLine("Неверно задан размер массива!");
    return;
}

int[] myArray = Arrays.CreateRandomArray(arraySize, 0, 100);
Arrays.PrintArray(myArray);
WriteLine($"Разница между min и max = {Arrays.ArrayMinMaxDelta(myArray)}");