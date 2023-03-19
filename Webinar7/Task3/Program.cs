/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
Дан двумерный массив. Поменять местами:
а) элементы, расположенные в правом верхнем и левом нижнем углах;
б) элементы, расположенные в правом нижнем и левом верхнем углах.
Дан двумерный массив. Составить программу:
а) расчета суммы двух любых элементов второй строки массива;
б) расчета произведения двух любых элементов пятого столбца массива.
Сложить все элементы выше главной диаганали
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

int FindSumNumbersLocatedDiagonally(int[,] array2D)
{
    int summNumbers = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i == j)
            {
                summNumbers += array2D[i, j];
            }
        }
    }    
    return summNumbers;
}

//int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int size = 12;
int[,] array2D = CreateArray(5, 7);

FillingArray(array2D, 1, 10);
System.Console.WriteLine("Исходный массив: ");
PrintArrayInConsole(array2D);
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"Сумма чисел на главной диагонали = {FindSumNumbersLocatedDiagonally(array2D)};");
Console.ResetColor();
