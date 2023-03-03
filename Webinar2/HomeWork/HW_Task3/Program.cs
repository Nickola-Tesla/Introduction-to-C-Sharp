// See https://aka.ms/new-console-template for more information
Console.Write("введите порядковй номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
while ((number < 1) || (number > 7))
{
    Console.Write("У нас пока нет такого дня недели, их пока только 7, повторите ввод: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if ((number > 0) && (number < 6))
{
    Console.Write("Это будний день, и если вы до сих пор не наработе то вы прогульщик, ну или еще ночь и надо спать, а вы тут цыфорки вводите!");

}
else if ((number >= 6) && (number <= 7))
{
    Console.Write("Это выходной день, идите скорее отсыпаться, ведь скоро опять на работу!");
}
