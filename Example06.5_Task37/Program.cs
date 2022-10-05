/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetArrayOfNumber(int length)
{
    int [] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(1, 10);
    }
    return arrayOfNumbers;
}

int[] GetMultiplayOfArray(int[] array)
{
    int length = (int)Math.Ceiling(array.Length/2.0); //Math.Ceiling округление в большую сторону
    int[] multiArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        if (i == array.Length - 1 -i)
        {
        multiArray[i] = array[i];    
        }
        else
        {
        multiArray[i] = array[i] * array[array.Length - 1 -i];    
        }
    }
    return multiArray; 
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

int[] array = GetArrayOfNumber(6);
int[] res = GetMultiplayOfArray(array);

printArray(array);
printArray(res);