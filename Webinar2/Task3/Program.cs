// See https://aka.ms/new-console-template for more information

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber%secondNumber == 0) {
    Console.WriteLine("Кратно");
}else{
    Console.WriteLine($"Не кратно = {firstNumber%secondNumber}");
}