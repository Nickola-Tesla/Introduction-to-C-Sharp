/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/
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

void ReplacingFirstLastRowsArray2D(int[,] array2d)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        int temp = array2d[0, j];
        array2d[0, j] = array2d[array2d.GetLength(0) - 1, j];
        array2d[array2d.GetLength(0) - 1, j] = temp; 
    }
}

//int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int[,] array2D = CreateArray(3, 4);
FillingArray(array2D, 1, 10);
PrintArrayInConsole(array2D);
System.Console.WriteLine();
ReplacingFirstLastRowsArray2D(array2D);
PrintArrayInConsole(array2D);