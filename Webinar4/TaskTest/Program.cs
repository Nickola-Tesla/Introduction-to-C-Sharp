// See https://aka.ms/new-console-template for more information
int InputNumberWithMessage(string message)
{    
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Summ(int A, int B){
    return A + B;
}
/*Console.WriteLine("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());*/

int A = InputNumberWithMessage("Введите A");
int B = InputNumberWithMessage("Введите B");


A = Summ(A, B);
System.Console.WriteLine(A);

