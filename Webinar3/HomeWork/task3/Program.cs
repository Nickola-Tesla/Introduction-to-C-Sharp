/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вариант 1: ");
for (int i = 1; i <= number; i++)
{
    if (i == number)
    {
      Console.Write(Math.Pow(i, 3) + ";");  
    }else
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    
}
Console.Write("Вариант 2: ");
for (int i = 1; i < number; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");    
}
Console.Write(Math.Pow(number, 3) + ";"); 