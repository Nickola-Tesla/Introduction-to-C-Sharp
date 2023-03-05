// See https://aka.ms/new-console-template for more information
int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FindThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
int number = InputNumberWithMessage("Введите число");

if (number < 100)
{
    System.Console.WriteLine("третего символа нет");
    return;
}

System.Console.WriteLine(FindThirdDigit(number));
