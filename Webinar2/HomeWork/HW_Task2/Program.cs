// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine(number + " в введенном числе третьей цифры нет!");
}else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра введенного числа = " + number % 10);
}
