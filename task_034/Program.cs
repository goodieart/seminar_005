// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

int[] array = ArrayCreate(6);
ArrayPrint(array);
WriteLine(ArrayEvenCount(array));

int[] ArrayCreate(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++) result[i] = rnd.Next(100, 1000);
    return result;
}

void ArrayPrint(int[] array)
{
    WriteLine($"[{string.Join(",", array)}]");
}

int ArrayEvenCount(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) result++;
    } 
    return result;
}