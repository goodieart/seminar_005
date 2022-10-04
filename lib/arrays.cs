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
}
