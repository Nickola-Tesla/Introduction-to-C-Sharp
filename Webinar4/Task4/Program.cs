// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.*/

void FillingAnArrayWithRandomNumbers(int[] arr, Random rnd)
{
   
   for (int i = 0; i < arr.Length; i++)
   {
        arr[i] = rnd.Next(0, 2);
   }
}

int[] arr = new int[8];
Random rnd = new Random();
FillingAnArrayWithRandomNumbers(arr, rnd);

for (int i = 0; i < arr.Length; i++)
   {
    if(i == (arr.Length - 1))
    {
        Console.Write(arr[i] + ";");
    }
    else
    {
        Console.Write(arr[i] + ", ");    
    }
   }