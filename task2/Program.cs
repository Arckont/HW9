// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int SumNoEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum += arr [i];
    }
    return sum;
}

int size = WWU("введите размер массива: ");
int minValue = WWU("введите мин массива: ");
int maxValue = WWU("введите макс массива: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
int sum = SumNoEvenNumbers(array);
Console.WriteLine("сумма нечетных элементов: " + sum);