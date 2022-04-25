/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArrayOfNumber(int length)
{
    int [] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(1, 150);
    }
    return arrayOfNumbers;
}

int GetAmountElementOfArray(int[] arrayOfNumbers)
{
        int AmountElement = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] > 10 && arrayOfNumbers[i] < 99)
            {
                AmountElement++;
            }
        }
        return AmountElement;
}

/*void printArray(int[] arrayOfNumbers)
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
*/

int[] arrayOfNumbers = GetArrayOfNumber(123);
int AmountElement = GetAmountElementOfArray(arrayOfNumbers);
Console.WriteLine($"количество элементов в массиве в деопазоне от 10 до 99 = {AmountElement}");
