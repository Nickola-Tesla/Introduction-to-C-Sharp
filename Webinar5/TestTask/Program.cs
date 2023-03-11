//Задача 31: Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
(int moreThanZero, int lessThanZero) GetSummNumbersLessAndMoreThanZero(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            amounts.moreThanZero += array[i];
        else
            amounts.lessThanZero += array[i];
    }
}

int size = 12;
int[] array = CreateAndFillingArray(size, -9, 10);
PrintArrayInConsole(array);
(int moreThanZero, int lessThanZero) GetSummNumbersLessAndMoreThanZero(int[] array);

System.Console.WriteLine($"Больше 0 = {amounts.moreThanZero}, меньше 0 = {amounts.lessThanZero},");