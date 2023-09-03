// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
      if(arr[i] > max) max = arr[i];  
    }
    return max; 
}
double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
      if(arr[i] < min) min = arr[i];  
    }
    return min;  
}

double DiffMaxMin(double max, double min)
{
    double diffMaxMin = max - min;
    return diffMaxMin;
}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(array);
Console.WriteLine();
double maxElement = MaxElement(array);
Console.WriteLine($"Максимальный элемент массива - {maxElement:F1}");   
double minElement = MinElement(array);
Console.WriteLine($"Минимальный элемент массива - {minElement:F1}");  
double result = DiffMaxMin(maxElement, minElement);
Console.Write($"Разница между максимальным и минимальным элементов массива - {result:F1}.");