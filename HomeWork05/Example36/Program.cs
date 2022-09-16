/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int Numbers(int amountnummbers, int min, int max)
{
    int[] numbers = new int[amountnummbers];
    int sumElements = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);

        Console.Write(numbers[i]+ " ");
        
        if (i % 2 == 1)
        {
            sumElements += numbers[i];
           // Console.WriteLine(sumElements);
        }
    }
    return sumElements;
}


int amountnummbers = Convert.ToInt32(Console.ReadLine());
int numbers = Numbers(amountnummbers, -10 , 10);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {numbers}");