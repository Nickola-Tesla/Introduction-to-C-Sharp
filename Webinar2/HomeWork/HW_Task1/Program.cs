// See https://aka.ms/new-console-template for more information
Console.Write("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while ((number < 99) || (number > 1000))
{
    Console.Write("Нет вы все же введите ТРЕХзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int result = number % 100 / 10;
Console.WriteLine(result);

