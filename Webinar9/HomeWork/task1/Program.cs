/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void OutputOfNaturalNumbers(int number)
{
    if (number == 1)
    {
        Console.WriteLine(number + ";");
    }
    else
    {
        Console.Write(number + ", ");
        OutputOfNaturalNumbers(--number);
    }
}


int number = InputNumberWithMessage("Введите число N: ");


OutputOfNaturalNumbers(number);