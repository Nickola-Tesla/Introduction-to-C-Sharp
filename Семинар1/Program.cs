// Практика по лекции 1
//Пример 1 - Ввод имени и вывод приветсвия
/*Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
Console.WriteLine("Привет, " );
Console.WriteLine(username);
Console.Write("Привет, " );
Console.Write(username);
// Пример 2 - программа сложения 2-х чисел
int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);
//или 
int result = numberA + numberB;
Console.WriteLine(result);
// Пример применения ГСЧ
int numberA = new Random().Next(0, 100);
Console.WriteLine(numberA);*/
Console.WriteLine("Задача № 2");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
   Console.WriteLine("Болшее значение = " + a);
}else if(b > a)
{
    Console.WriteLine("Болшее значение = " + b);
}else
{
    Console.WriteLine("Значения равны: " + a + " = " + b);
}
Console.WriteLine("Задача № 4");
Console.Write("Введите 3 числа через пробел: ");
string[] array1 = Console.ReadLine()!.Split(" ");
int i = 0, size = array1.Length;
int max = Convert.ToInt32(array1[0]);

while (i < size)
{
    if (max < Convert.ToInt32(array1[i]))
    {
        max = Convert.ToInt32(array1[i]);
    }
    i++;
}
Console.WriteLine(max);
Console.WriteLine("Задача № 4");











//Console.ReadLine()