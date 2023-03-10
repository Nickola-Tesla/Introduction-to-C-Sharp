/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummingTheDigitsOfTheEnteredNumber(int number)
{
    int result = 0;
    if (number < 0)
    {
        number *= -1;
    }
    while (number > 0)
    {
        result += number%10;
        number /= 10;
    }
    return result;
}
int number = InputNumberWithMessage("Введите число : ");

Console.WriteLine("Сумма цифр введенного числа = " + SummingTheDigitsOfTheEnteredNumber(number));

