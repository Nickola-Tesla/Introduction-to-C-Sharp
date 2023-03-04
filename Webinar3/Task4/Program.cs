// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.*/
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат: ");
for (int i = 1; i <= n; i++)
{
    if (i == n)
    {
       Console.Write(Math.Pow(i, 2) + ";"); 
    }else
    {
       Console.Write(Math.Pow(i, 2) + ", "); 
    }
    
}
