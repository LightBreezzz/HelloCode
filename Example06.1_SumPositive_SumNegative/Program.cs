int[] GetArrayOfNumber(int length, int deviation)
{
    int [] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation,deviation+1);
    }
    return arrayOfNumbers;
}

int GetPositiveSumElementOfArray(int[] arrayOfNumbers)
{
        int positiveSum = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] > 0)
            {
                positiveSum += arrayOfNumbers[i];
            }
        }
        return positiveSum;
}
int GetNegativeSumElementOfArray(int[] arrayOfNumbers)
{
        int negativeSum = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] < 0)
            {
                negativeSum += arrayOfNumbers[i];
            }
        }
        return negativeSum;
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

int[] arrayOfNumbers = GetArrayOfNumber(12,9);
int positiveSum = GetPositiveSumElementOfArray(arrayOfNumbers);
int negativeSum = GetNegativeSumElementOfArray(arrayOfNumbers);
Console.WriteLine("В массиве:");
printArray(arrayOfNumbers);
Console.WriteLine($"Сумма положительных {positiveSum}, сумма отрицательных {negativeSum}");