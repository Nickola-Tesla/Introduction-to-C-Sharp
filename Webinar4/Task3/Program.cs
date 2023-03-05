// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplyingANumberByItSelf(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
    /*int pr = 1;
    while (number > 0)
    {
        pr *= number % 10;
        number /= 10;
    }
    return pr;*/
}

int number = InputNumberWithMessage("Введите число: ");
number = MultiplyingANumberByItSelf(number);
System.Console.WriteLine(number);

