/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.*/
bool IsRealTriangl(double ab, double bc, double ac)
{
    return ab < bc + ac && bc < bc + ac && ac < ab + bc;
}

double ab = Convert.ToDouble(Console.ReadLine());
double bc = Convert.ToDouble(Console.ReadLine());
double ac = Convert.ToDouble(Console.ReadLine());
if (IsRealTriangl(ab, bc, ac))
    System.Console.WriteLine("Может");
else
    System.Console.WriteLine("не может");