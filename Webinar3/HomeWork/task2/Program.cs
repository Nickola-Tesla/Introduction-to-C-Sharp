// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/
Console.Write("Введите координату X точка a: ");
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
Console.WriteLine("расстояние между a и b в 3D пространстве = " + result);