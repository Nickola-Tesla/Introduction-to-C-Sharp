/*Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

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

//int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int size = 12;
int[,] array2D = CreateArray(3, 4);
FillingArray(array2D, 1, 10);
PrintArrayInConsole(array2D);
