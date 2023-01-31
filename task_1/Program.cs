/* 
 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 
*/
int[] GetRandomArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int NumbersOfEven(int[] arr)
{
    var count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}
int[] array = GetRandomArray(5);
Console.WriteLine(string.Join(",", array));
int number = NumbersOfEven(array);
Console.Write($"Количество четных чисел  в массиве равно -> {number}");