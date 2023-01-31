/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] GetRandomArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}
int SummaOddNumber(int[] arr)
{
    var summa = 0;
    var count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            summa += arr[i];
            count++;
        }
    }
    if (count == 1) summa = 0;

    return summa;
}
int[] array = GetRandomArray(5);
Console.WriteLine(string.Join(",", array));
int summaOdd = SummaOddNumber(array);
Console.Write($"Сумма нечетных чисел в массиве ранв -> {summaOdd}");