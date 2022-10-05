/*
    Напишите программу, которая перевернет одномерный массив
    [1 2 3 4 5] -> [5 4 3 2 1]
*/
double [] CreateArray(int length)
{
    double [] array = new double [length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (1, 10);
    }
    return array;
} 

double [] CreateArrayRevers(double [] array)
{
    double[] number = new double [array.Length];
    int length = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        number[i] = array[length-1];
        length = length -1;
    }
    return number;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Введите длину массива: ");
int LenghtArray = Convert.ToInt32(Console.ReadLine());
double [] arr = CreateArray(LenghtArray);
double [] number = CreateArrayRevers(arr);

ShowArray(arr);
Console.WriteLine();
ShowArray(number);
