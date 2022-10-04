namespace Lib;
public class Arrays
{
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

    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(",", array)}]");
    }

    public static int ArrayEvenCount(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) result++;
        }
        return result;
    }

    public static int ArrayModSum(int[] array)
    {
        int result = 0;
        for (int i = 1; i < array.Length; i += 2) result += array[i];
        return result;
    }
}
