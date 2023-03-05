// See https://aka.ms/new-console-template for more information
int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummDigitNumbers(int number)
{
    int summ = 0;
    for (int i = 0; i < number; i++)
    {
        summ += i;
    }
    return summ;
}

int A = InputNumberWithMessage("Введите число");
System.Console.WriteLine(SummDigitNumbers(A));