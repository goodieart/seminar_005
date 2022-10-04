namespace Lib;
public class Arrays
{
    /// <summary>
    /// Метод возвращает заполненный случайными числами массив в указанном диапазоне
    /// </summary>
    public static int[] CreateRandomArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rnd.Next(minValue, maxValue + 1);
        }
        return result;
    }
    
    /// <summary>
    /// Метод выводит в консоль содержимое массива через разделитель
    /// </summary>
    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(",", array)}]");
    }
    
    /// <summary>
    /// Метод возвращает количество четных чисел в массиве
    /// </summary>
    public static int ArrayEvenCount(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) result++;
        }
        return result;
    }
    
    /// <summary>
    /// Метод возвращает сумму элементов на нечетных позициях
    /// </summary>
    public static int ArrayModSum(int[] array)
    {
        int result = 0;
        for (int i = 1; i < array.Length; i += 2) result += array[i];
        return result;
    }
    
    /// <summary>
    /// Метод возвращает разницу между максимальным и минимальным элементами массива
    /// </summary>
    public static int ArrayMinMaxDelta(int[] array)
    {
        int min = array[0], max = array[0];
        foreach (int i in array)
        {
            if (i > max) max = i;
            if (i < min) min = i;
        }
        return max - min;
    }
}
