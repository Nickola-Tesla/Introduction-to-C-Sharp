/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] CreateAndFillingArray(int size, int lefntRangeValue, int rightRangeValue)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(lefntRangeValue, rightRangeValue);
    }
    return array;
}

void PrintArrayInConsole(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int SearchingForANumberInAnArray(int[] array)
{
    int intermediateResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
           intermediateResult++;
        }
    }
    return intermediateResult;
}

int size = 123;

int[] array = CreateAndFillingArray(size, 0, 124);
/* Массивы использованные для проверки!
int[] array = {5, 18, 123, 6, 2};
int[] array = {1, 2, 3, 6, 2};
int[] array = {10, 11, 12, 13, 14};
*/
PrintArrayInConsole(array);
int result = SearchingForANumberInAnArray(array);

if (result > 0)
{
    Console.WriteLine($"Найдено совпадающих элементов = {result} из диапозона от 10 до 99!");
} else
{
    Console.WriteLine($"Из диапозона от 10 до 99 не найдено ни одного совпадающего числа!");
}
