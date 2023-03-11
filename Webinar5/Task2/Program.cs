/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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
bool SearchingForANumberInAnArray(int[] array, int theDesiredNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == theDesiredNumber)
        {
            return true;
        }
    }
    return false;
}
int theDesiredNumber = InputNumberWithMessage("Введите число которое необходимо найти в массиве: ");
int size = 12;
int[] array = CreateAndFillingArray(size, -9, 10);
PrintArrayInConsole(array);

if (SearchingForANumberInAnArray(array, theDesiredNumber))
{
    Console.WriteLine("Искомое число было обнаружен в массиве");
} else
{
    Console.WriteLine("Искомое число НЕ было обнаружен в массиве");
}

