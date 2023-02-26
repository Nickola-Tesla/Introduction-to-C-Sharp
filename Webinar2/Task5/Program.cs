// See https://aka.ms/new-console-template for more information
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool isSquare = Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber;
if (isSquare)
{
    Console.WriteLine("Это квадрат числа");    
}else
{
    Console.WriteLine("Что то не получилось");    
}

