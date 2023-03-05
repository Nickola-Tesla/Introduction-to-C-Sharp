// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputNumberWithMessage("Введите число: ");
int index = (int)Math.Log10(number) + 1;
System.Console.WriteLine(index);
