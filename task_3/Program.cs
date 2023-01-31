/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


double[] GetArrayRandom(int dimension)//рандом массива
{
    double[] array = new double[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.NextDouble();
    }
    return array;
}
double FindMax(double[] arr)// находим максимальное
{
    double maxNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNumber < arr[i])
        {
            var empty = arr[i];
            arr[i] = maxNumber;
            maxNumber = empty;
        }
    }
    return maxNumber;
}
double FindMin(double[] arr)//минимальное
{
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minNumber > arr[i])
        {
            var empty = arr[i];
            arr[i] = minNumber;
            minNumber = empty;
        }
    }
    return minNumber;
}
double DiferenceMaxAndMin(double max, double min)// разница
{
    double diference = max - min;
    return diference;
}
double[] array = GetArrayRandom(5);
Console.WriteLine(string.Join("->", array));
double min = FindMin(array);
double max = FindMax(array);
double diferenceMaxMin = DiferenceMaxAndMin(max, min);
Console.WriteLine($"Разница максимального  ->{max} и минимальногочисла  -> {min}  равна -> {diferenceMaxMin} ");