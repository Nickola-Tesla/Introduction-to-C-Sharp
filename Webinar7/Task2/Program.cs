/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArray(int rows, int colons)
{
    int[,] array2D = new int[rows, colons];
    return array2D;
}

void FillingArray(int[,] array2D, int lefntRangeValue, int rightRangeValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(lefntRangeValue, rightRangeValue);
        }
    }
}

void PrintArrayInConsole(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SquarValuesEvenPositionsArray(int[,] array2D)
{
    /*for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array2D[i, j] *= array2D[i, j];
            }
        }
    }*/
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if ((i % 2 == 0))
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    array2D[i, j] *= array2D[i, j];
                }
            }
        }
    }
}



//int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int size = 12;
int[,] array2D = CreateArray(3, 4);

FillingArray(array2D, 1, 10);
System.Console.WriteLine("Исходный массив: ");
PrintArrayInConsole(array2D);

SquarValuesEvenPositionsArray(array2D);
System.Console.WriteLine("Обработанный массив: ");
PrintArrayInConsole(array2D);