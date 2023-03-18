/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibanacci(int number)
{
    double firstNumber = 0;
    double secondNumber = 1;
    int ind = 1;
    System.Console.WriteLine(ind + "! " + firstNumber + " ");
    for (int i = 0; i < number; i++)
    {
        ind++;
        System.Console.WriteLine(ind + "! " + secondNumber + " ");
        double buffer = secondNumber;
        secondNumber += firstNumber;
        firstNumber = buffer;
    }
}

int number = InputNumberWithMessage("Введите число N: ");

Fibanacci(number);
