/*
 Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 6, 1, 33 -> [6, 1, 33]
*/

int[] GetArrayOfNumber(int length)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(1, 50);
    }
    return arrayOfNumbers;
}

void printNumbers(int[] arrayOfNumbers)
{
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.Write(" -> ");
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

int[] array = GetArrayOfNumber(8);

printNumbers(array);
printArray(array);
