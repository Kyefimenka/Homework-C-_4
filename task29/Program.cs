// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = GetIntegerArray(8);
System.Console.WriteLine($"[{String.Join("; ", array )}]");

int[] GetIntegerArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(10);
    }
    return resultArray;
}
