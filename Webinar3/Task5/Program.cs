// See https://aka.ms/new-console-template for more information
System.Console.Write("Введите массу выбранного арбуза: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 != 0)
{
    System.Console.WriteLine("Не получается поделить арбуз на четные доли");
    return;
}
for (int i = 1; i < N; i++)
{
    if (i % 2 == 0){
        System.Console.WriteLine($"{N - i} : {i}");
    }      
}
    
