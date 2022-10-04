using static System.Console;

int[] array = ArrayCreate(6);
ArrayPrint(array);
Write(ArrayModSum(array));

int[] ArrayCreate(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++) result[i] = rnd.Next(-100, 100);
    return result;
}

void ArrayPrint(int[] array)
{
    WriteLine($"[{string.Join(",", array)}]");
}

int ArrayModSum(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i+=2) result += array[i];
    return result;
}