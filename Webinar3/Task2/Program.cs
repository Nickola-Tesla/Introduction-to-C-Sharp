// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/
Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

/*if (number == 1)
{
    Console.WriteLine("X > 0, Y > 0" );
}else if (number == 2)
{
    Console.WriteLine("X < 0, Y > 0" );
}else if (number == 3)
{
    Console.WriteLine("X < 0, Y < 0" );
}else if (number == 4)
{
    Console.WriteLine("X > 0, Y < 0" );
}else
{
    Console.WriteLine("нет такого поля координат!");
}*/

switch (number)
{
    case 1:
        Console.WriteLine("X > 0, Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0, Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0, Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0, Y < 0");
        break;
    default: 
        Console.WriteLine("нет такого поля координат!");
        break;
}