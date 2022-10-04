using Lib;
using static System.Console;

Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);

int[] myArray = Arrays.CreateRandomArray(arraySize, -100, 100);
Arrays.PrintArray(myArray);
WriteLine($"Сумма чисел на нечетных позициях = {Arrays.ArrayModSum(myArray)}");