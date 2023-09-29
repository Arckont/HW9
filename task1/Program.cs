// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int WWU(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min, max + 1);
    }
    return result;

}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine( );
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] % 2 == 0)
        count++;
    }
    return count;
}

int size = WWU("введите размер массива: ");
int minValue = WWU("введите мин массива: ");
int maxValue = WWU("введите макс массива: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
int count = EvenNumbers(array);
Console.WriteLine("количество четных элементов: " + count);