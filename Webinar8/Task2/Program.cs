/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
[nXn]
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/
/*int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}*/

int[,] CreateArray(int row, int colons)
{
    int[,] array2D = new int[row, colons];
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
/*
int[,] TransposingAnArray2D(int[,] array2d)
{
    int[,] tempArray2D = CreateArray(array2d.GetLength(1), array2d.GetLength(0));
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            tempArray2D[j, i] = array2d[i, j];          
        }
    }
    return tempArray2D;//[]
}
*/
void PrintTranspositionArrayInConsole(int[,] array2D)
{
   for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[j, i] + " ");
        }
        System.Console.WriteLine();
    }
}
//int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int[,] array2D = CreateArray(4, 4);
FillingArray(array2D, 1, 99);
PrintArrayInConsole(array2D);
System.Console.WriteLine();
/*array2D = TransposingAnArray2D(array2D);
PrintArrayInConsole(array2D);*/
PrintTranspositionArrayInConsole(array2D);
