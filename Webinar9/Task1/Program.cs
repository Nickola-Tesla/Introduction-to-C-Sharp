/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

using System.Reflection.Metadata.Ecma335;

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Pow(int A, int B)
{
    if (B == 1)
        return A;

     return A * Pow(A, B - 1);
}


int A = InputNumberWithMessage("Введите число A: ");
int B = InputNumberWithMessage("Введите число B: ");
int Message = InputNumberWithMessage("Введите число 42: ");
Console.WriteLine(Pow(A, B));


if (Message != 42)
{
    Console.WriteLine("Вы ввели не верное значение");
}
else
{
   Console.WriteLine($"Ответ на вопрос жизни, вселенной и вообще = {Message}"); 
}
