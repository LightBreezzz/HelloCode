/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
     array[i] = new Random().Next(min, max);   
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i]);
     if (i != array.Length -1)
     {
        Console.Write(",");
     }   
    }
    Console.Write("]");
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }   
    }
    return sum;
}

int[] numbers = new int[10];
FillArray(numbers, 100, 1000);
PrintArray(numbers);
Console.Write(" -> ");

int Sum = SumPositive(numbers);
Console.WriteLine($"Колличество четных чисел в масивеж {Sum}");