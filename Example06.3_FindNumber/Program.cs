// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArrayOfNumber(int length, int deviation)
{
    int [] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation,deviation+1);
    }
    return arrayOfNumbers;
}

bool IsNumberInArray(int number, int[] arrayOfNumbers)
{
    bool isInArray = false;
    foreach (var item in arrayOfNumbers)
    {
        if(item == number)
        {
            isInArray = true;
            break;
        }
        else
        {
            isInArray = false;
        }
    }
    return isInArray;
}

void printArray(int[] arrayOfNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {   
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length -1)
        {
            Console.Write(",");
        }   
    } 
    Console.WriteLine("]");
}

int[] arrayOfNumbers = GetArrayOfNumber(5, 100);
System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
printArray(arrayOfNumbers);
bool isInArray = IsNumberInArray(number, arrayOfNumbers);
Console.WriteLine(isInArray);