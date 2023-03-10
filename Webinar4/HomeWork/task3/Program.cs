/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillingTheArray(int arrLength)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = InputNumberWithMessage($"Введите {i + 1} - й элемент массива: ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == (arr.Length - 1))
        {
            Console.Write($"{arr[i]};");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

int arrLength = InputNumberWithMessage("Введите длину массива: ");
int[] arr = FillingTheArray(arrLength);
PrintArray(arr);