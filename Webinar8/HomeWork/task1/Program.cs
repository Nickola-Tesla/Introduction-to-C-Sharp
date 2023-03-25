/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] CreateArray(int row, int colons)
{
    int[,] array2D = new int[row, colons];
    return array2D;
}

void FillingArray(int[,] array2D)
{
    Random rnd = new Random();
    int rows = array2D.GetLength(0);
    int columns = array2D.GetLength(1);
    int halfRows = array2D.GetLength(0) / 2;
    int halfcolumns = array2D.GetLength(1) / 2;
    int k = 0;
    int currentElements = 0;
    for (int i = 0; i < halfRows; i++)
    {
        for (k = 0; k < columns; k++)
            array2D[i, k] = currentElements;
        columns--;

        for (k = i + 1; k < rows; k++)
            array2D[k, rows - 1] = currentElements++;
       

        for (k = columns - 1; k >= i; k--)
            array2D[rows - 1, k] = currentElements++;
        rows--;

        for (k = rows - 1; k >= i +1; k--)
            array2D[k, i] = currentElements++;
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

int[,] array2D = CreateArray(4, 4);
FillingArray(array2D);
PrintArrayInConsole(array2D);

/*// Напишите программу, которая заполнит спирально массив 4 на 4.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write (array[i,j] + " ");
        }

        System.Console.WriteLine();
    }
    
    System.Console.WriteLine();
}

void SpiralFilling(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int halfRows = array.GetLength(0) / 2;

    int k = 0;
    int currentElement = 0;
    for (int i = 0; i < halfRows; i++)
    {
        for (k = 0; k < columns; k++)
            array[i, k] = currentElement ++;

        columns--;
        
        for ( k = i + 1; k < rows; k++)
            array[k, rows - 1] = currentElement ++;

        
        for (k = columns - 1; k >= i; k --)
            array[rows - 1, k] = currentElement ++;
        
        rows--;
        // -1
        for (k = rows - 1;  k >= i + 1; k --)
            array[k, i] = currentElement ++;
    }
}

int size = 3;
int[,] array = new int[size, size];
SpiralFilling(array);
PrintArray(array);*/