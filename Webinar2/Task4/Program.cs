// See https://aka.ms/new-console-template for more information
int firstNumber = Convert.ToInt32(Console.ReadLine());
if ((firstNumber%7 == 0) && (firstNumber%23 == 0)) {
    Console.WriteLine("Кратно");
}else if((firstNumber%7 == 0) && (firstNumber%23 != 0)){
    Console.WriteLine($"Кратно 7  = {firstNumber%7}");
    Console.WriteLine($"Не кратно 23 = {firstNumber%23}");
}else if((firstNumber%7 != 0) && (firstNumber%23 == 0)){
    Console.WriteLine($"Не кратно 7  = {firstNumber%7}");
    Console.WriteLine($"Кратно 23 = {firstNumber%23}");
}else{
    Console.WriteLine($"Не кратно 7  = {firstNumber%7}");
    Console.WriteLine($"Не кратно 23 = {firstNumber%23}");
}
