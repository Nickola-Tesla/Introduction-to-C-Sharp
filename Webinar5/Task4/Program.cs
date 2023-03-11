/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

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

void SearchingForANumberInAnArray(int[] array)
{
    for (int j = 0; j < (array.Length / 2 + array.Length % 2); j++)
    {
        if (j == array.Length - j - 1)
        {
           Console.WriteLine($"Произведение {array[j]}");  
        }else
        {
           Console.WriteLine($"Произведение {array[j]} * {array[array.Length - j - 1]} =  {array[j] * array[array.Length - j - 1]}"); 
        }
    }
}

int size = InputNumberWithMessage("Введите размер массива: ");
int[] array = CreateAndFillingArray(size, 0, 99);
PrintArrayInConsole(array);
SearchingForANumberInAnArray(array);