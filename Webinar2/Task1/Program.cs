// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int number = rnd.Next(1, 100);

Console.WriteLine(number);
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine(firstDigit + " " + secondDigit);
int maxDigit = Math.Max(firstDigit, secondDigit);
Console.WriteLine(maxDigit);
