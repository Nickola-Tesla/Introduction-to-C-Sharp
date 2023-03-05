// See https://aka.ms/new-console-template for more information
int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintDayOfWeekByNumber(int dayOfWeek)
{
    if (dayOfWeek >= 1 && dayOfWeek <= 5)
    {
        System.Console.WriteLine("Рабочие");
    }
        else if (dayOfWeek >= 6 && dayOfWeek <= 7)
    {
        System.Console.WriteLine("выходные");
    }
    else
    {
        System.Console.WriteLine("неправильно");
    }
}
int dayOfWeek = InputNumberWithMessage("Введите число");

PrintDayOfWeekByNumber(dayOfWeek);