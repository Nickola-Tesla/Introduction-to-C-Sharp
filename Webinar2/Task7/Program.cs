// See https://aka.ms/new-console-template for more information
int sum = 0;
for (int i = 0; i < 10; i++)
{
    sum += (int)Math.Pow(2, i);
    Console.Write((int)Math.Pow(2, i) + " ");
}
Console.WriteLine(sum);