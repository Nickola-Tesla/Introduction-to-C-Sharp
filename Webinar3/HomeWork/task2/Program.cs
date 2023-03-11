// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/
/*Console.Write("Введите координату X точка a: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точка a: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точка a: ");
double Za = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координату X точка b: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точка b: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точка b: ");
double Zb = Convert.ToDouble(Console.ReadLine());

//double lengthX = Math.Pow(Xa - Xb, 2);
//double lengthY = Math.Pow(Ya - Yb, 2);
double result = Math.Round(Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2) + Math.Pow(Za - Zb, 2)), 2);
Console.WriteLine("расстояние между a и b в 3D пространстве = " + result);*/
double GetImputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

(double X, double Y, double Z) GetPointIn3DArea()
{
    double X = GetImputNumber("Введите координату X");
    double Y = GetImputNumber("Введите координату Y");
    double Z = GetImputNumber("Введите координату Z");

    return (X,Y,Z);
}
double GetDistanceIn3DArea((double X, double Y, double Z) point1, (double X, double Y, double Z) point2)
{
    double lengthX = Math.Pow(point2.X - point1.X, 2);
    double lengthY = Math.Pow(point2.Y - point1.Y, 2);
    double lengthZ = Math.Pow(point2.Z - point1.Z, 2);
    return Math.Sqrt(lengthX + lengthY + lengthZ);
}

(double X, double Y, double Z) point1 = GetPointIn3DArea();
(double X, double Y, double Z) point2 = GetPointIn3DArea();

Console.WriteLine("Расстояние между точками: " + Math.Round(GetDistanceIn3DArea(point1, point2)), 2);