/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


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

int[,] MatrixЬultiplication(int[,] array2dFirst, int[,] array2dSecond)
{
    int[,] tempArray = new int[array2dFirst.GetLength(0), array2dSecond.GetLength(1)];
    
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < array2dFirst.GetLength(1); k++)
            {
                tempArray[i, j] += array2dFirst[i, k] * array2dSecond[k, j]; 
            }
        }

    }
    return tempArray;
}




//int rows = InputNumberWithMessage("Введите число строк Матрицы 1: ");
//int columns = InputNumberWithMessage("Введите число колонок Матрицы 1: ");

//int rows1 = InputNumberWithMessage("Введите число строк Матрицы 2: ");
//int columns1 = InputNumberWithMessage("Введите число колонок Матрицы 2: ");

// while (rows != columns1)
//{
//    rows = InputNumberWithMessage("Введите число строк Матрицы 1: ");
//    columns = InputNumberWithMessage("Введите число колонок Матрицы 1: ");

//    rows1 = InputNumberWithMessage("Введите число строк Матрицы 2: ");
//    columns1 = InputNumberWithMessage("Введите число колонок Матрицы 2: ");
//}





//int[,] array2DFirst = { { 2, 4 }, { 3, 2 } };
int[,] array2DFirst = { { 0, -1, 2}, {2, 1, 1}, {3, 0, 1}, {3, 7, 1}};//CreateArray(2, 2);
//FillingArray(array2DFirst, 1, 10);
PrintArrayInConsole(array2DFirst);
Console.WriteLine();
//int[,] array2DSecond = { { 3, 4 }, { 3, 3 } };
int[,] array2DSecond = { { 3, 1}, {2, 1}, {1, 0}};//CreateArray(2, 2);
//FillingArray(array2DSecond, 1, 10);
PrintArrayInConsole(array2DSecond);
System.Console.WriteLine();

PrintArrayInConsole(MatrixЬultiplication(array2DFirst, array2DSecond));

