// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine(number);
int fistDigit = number / 100 * 10;
int lastDigit = number % 10;
int result = fistDigit + lastDigit;
Console.WriteLine(result);


