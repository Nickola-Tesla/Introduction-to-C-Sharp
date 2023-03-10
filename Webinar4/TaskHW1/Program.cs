// See https://aka.ms/new-console-template for more information

int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = InputNumberWithMessage("Введите трехзначное число");

if (number < 100 || number > 999)
{
    System.Console.WriteLine("Неправильный ввод");
    return;
}

int result = number / 10 % 10;
System.Console.WriteLine($"{number}".GetType());

/*string numberInString = Console.ReadLine();
Console.WriteLine(numberInString[1]);*/