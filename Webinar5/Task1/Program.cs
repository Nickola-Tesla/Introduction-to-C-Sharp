/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.*/


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
void ReverseArrayNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int size = 12;
int[] array = CreateAndFillingArray(size, -9, 10);
PrintArrayInConsole(array);
ReverseArrayNumbers(array);
Console.WriteLine(string.Join(",", array));
