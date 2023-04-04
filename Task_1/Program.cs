/*
    Задача
    Вам будет предоставлен массив чисел. Вы должны отсортировать нечетные числа в порядке возрастания, оставив четные числа на их исходных позициях.

    Примеры
    [7, 1]  =>  [1, 7]
    [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
    [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
 */

var arr = new int[] {};

var sortArr =  SortArray(arr);

Console.WriteLine(string.Join(",", sortArr));

static int[] SortArray(int[] array)
{
    var result = new int[array.Length];

    if (array.Length == 0)
        return result;

    var oddNumbers = array.Where(_ => _ % 2 != 0).ToList();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[i] = array[i];
        }
        else
        {
            var oddNumber = oddNumbers.Min();

            result[i] = oddNumber;

            oddNumbers.RemoveAt(oddNumbers.IndexOf(oddNumber));
        }
    }

    return result;
}