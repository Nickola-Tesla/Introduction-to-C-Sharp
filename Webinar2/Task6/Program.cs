// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;
for (int i = 1; i < n; i++)
{
    sum += (double)1/(double)i;
    Console.WriteLine((double)1/(double)i);
}
Console.WriteLine(sum);