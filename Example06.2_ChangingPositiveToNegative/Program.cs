// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArrayOfNumber(int length, int deviation)
{
    int [] arrayOfNumber = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumber[i] = new Random().Next(-deviation, deviation);
    }
    return arrayOfNumber;
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

int[] NigativeArray(int[] arrayOfNumbers)
{
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        arrayOfNumbers[i] *= -1;
    }
    return arrayOfNumbers;
}

int[] arrayOfNumbers = GetArrayOfNumber(4, 9);
printArray(arrayOfNumbers);
Console.WriteLine();
arrayOfNumbers = NigativeArray(arrayOfNumbers);
printArray(arrayOfNumbers);