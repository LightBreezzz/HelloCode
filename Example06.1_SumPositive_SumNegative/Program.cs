int[] GetArrayOfNumber(int length, int deviation)
{
    int [] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation,deviation+1);
    }
    return arrayOfNumbers;
}

int GetSumOfNegativeOrPositive(int[] arrayOfNumbers, bool isNegative)
{
    int positiveSum = 0;
    int multiplayer = 1;
    if (isNegative)
    {
        multiplayer = -1;
    }
    for (int i = 0; i < arrayOfNumbers.Length ; i++)
    {
        if (arrayOfNumbers[i] * multiplayer > 0)
        {
            positiveSum += arrayOfNumbers[i];
        }
    }
    return positiveSum;
}

/*
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
*/
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
int positiveSum = GetSumOfNegativeOrPositive(arrayOfNumbers, true);
int negativeSum = GetSumOfNegativeOrPositive(arrayOfNumbers, false);
Console.WriteLine("В массиве:");
printArray(arrayOfNumbers);
Console.WriteLine($"Сумма положительных {positiveSum}, сумма отрицательных {negativeSum}");