// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine( );
}

double Dif(double[] arr)
{
    double min = arr[0], max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
        else if (arr[i] > max)
        max = arr[i];
    }

    double Result = max - min;
    return Result;
}

double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
PrintArray(array);
double Result = Dif(array);
Console.Write("максимальное значение - минимальное значение = " + Result);