/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
}

double maxnumber = array[0];
double minnumber = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxnumber < array[i])
        {
            maxnumber = array[i];
        }

        if (minnumber > array[i])
        {
            minnumber = array[i];
        }
    }

double decision = maxnumber - minnumber;


Console.WriteLine($"Разница между максимальным {maxnumber} и минимальным {minnumber} элементом: {decision}");