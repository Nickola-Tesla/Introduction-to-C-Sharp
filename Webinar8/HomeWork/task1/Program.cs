/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArray(int row, int Columns)
{
    int[,] array2D = new int[row, Columns];
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

void BubbleSortArray2D(int[,] array2d)
{
    //int temp;
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
        {
            for(int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k];
                    array2d[i, k] = array2d[i, k + 1];
                    array2d[i, k + 1] = temp;
                }
            }            
        }
    }
}

int rows = InputNumberWithMessage("Введите число строк массива: ");
int columns = InputNumberWithMessage("Введите число колонок массива: ");

int[,] array2D = CreateArray(rows, columns);
FillingArray(array2D, 1, 10);
PrintArrayInConsole(array2D);
System.Console.WriteLine();
BubbleSortArray2D(array2D);
PrintArrayInConsole(array2D);

