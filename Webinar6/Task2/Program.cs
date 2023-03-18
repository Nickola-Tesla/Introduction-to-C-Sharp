/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10

void ReversPrintArray(int[] array)
{
    for (int i = array.Length - 1 ; i > 0; i--)
    {
        System.Console.Write(array[i] + " ");        
    }
}

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayReversal(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        number = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = number;
    }
    return array;
} 

void ResizeArray(int[] Array, int newSize)
{
    int[] newArray = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        newArray[i] = Array[i];
    }
    ReversPrintArray(newArray);
    //return newArray;
}

int[] ConvertingDecimalToBinary(int number)
{
    int[] remaindersOfDivision = new int[10];
    int index = 0;
    int currentRemaindersOfDivision = 0;
    while (number > 0)
    {
        currentRemaindersOfDivision = number % 2;
        remaindersOfDivision[index] = currentRemaindersOfDivision;
        number /= 2;
        index++;
        if (index == remaindersOfDivision.Length)
        {
            ResizeArray(remaindersOfDivision, index);
        }
    } 
    return ArrayReversal(remaindersOfDivision);
}


int number = InputNumberWithMessage("Введите число: ");

Console.WriteLine(String.Join("", ConvertingDecimalToBinary(number)));

//ConvertingDecimalToBinary(number);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int InvitationToInput(String message) // Метод вывода числа на экран
{
    System.Console.WriteLine(message); // Приглошение ко вводу чисел
    return Convert.ToInt32(System.Console.ReadLine()); // Конструкция для считывания вводимых данных
}

// void PrintArrayInConsosole(int[] array)
// {
//     Console.WriteLine(string.Join(",", array));
// }

int[] ResizeArray(int[] array, int newSize )
{
    int[] newArray = new int [newSize];
    
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i >= array.Length)
            break;
        
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintReverseArray(int[] array)
{
    for(int i = array.Length -1; i >= 0; i--)
    {
        System.Console.Write(array[i] + " ");
    }
}

int number = InvitationToInput("Введите число: ");

int[] remaindersOfTheDivision = new int[10];
int index = 0;
int courrentRemainderOfTheDivision = 0;

while (number != 0)
{
    courrentRemainderOfTheDivision = number % 2;
    remaindersOfTheDivision[index] = courrentRemainderOfTheDivision;
    number /= 2;
    index++;
    if (index == remaindersOfTheDivision.Length -1)
        remaindersOfTheDivision = ResizeArray(remaindersOfTheDivision, remaindersOfTheDivision.Length +10);
}
remaindersOfTheDivision = ResizeArray(remaindersOfTheDivision, index);
PrintReverseArray(remaindersOfTheDivision);