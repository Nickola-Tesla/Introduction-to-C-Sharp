/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Exponentiation(int number, int degree)
{
    int result = number;
    if (degree > 0)
    {
      for (int i = 2; i <= degree; i++)
      {
            result = result * number; 
      }
    }
    else
    {
        System.Console.WriteLine("неправильно");
    }
    Console.WriteLine("Число A в степени B = " + result);
}
int number = InputNumberWithMessage("Введите число A: ");
int degree = InputNumberWithMessage("Введите число B: ");

Exponentiation(number, degree);
