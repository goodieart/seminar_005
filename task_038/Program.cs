using static System.Console;

int[] array = ArrayCreate(5);
ArrayPrint(array);
Write(ArrayMinMaxDelta(array));

int[] ArrayCreate(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++) result[i] = rnd.Next(0, 100);
    return result;
}

void ArrayPrint(int[] array)
{
    WriteLine($"[{string.Join(",", array)}]");
}

int ArrayMinMaxDelta(int[] array)
{
    int min = array[0], max = array[0]; 
    foreach(int i in array) 
    {
        if(i > max) max = i;
        if(i < min) min = i;
    }
    return max - min;
}