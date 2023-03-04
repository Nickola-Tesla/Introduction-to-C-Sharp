// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.*/
double X = Convert.ToDouble(Console.ReadLine());

double Y = Convert.ToDouble(Console.ReadLine());
int part;
if (X > 0)
{
    /*if (Y > 0)
    {
        part = 1;
    }else
    {
        part = 4;
    }*/
    part = Y > 0 ? 1 : 4;

}else
{
    /*if (Y > 0)
    {
        part = 2;
    }else
    {
        part = 3;
    }*/
    part = Y > 0 ? 2 : 3;
}
Console.WriteLine("Четверть - " + part);
/*if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}*/

