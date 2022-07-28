/*
    Задача 25
    Напиши цикл, который принимает на вход два числа (А и В) 
    и возводит число А в натуральную степень В.
    3,5 -> 243(3^5)
    2,4 -> 16
*/

Console.Write("Введите число А - ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В - ");
int numberB = Convert.ToInt32(Console.ReadLine());

int GetNumberInDegree(int numberA, int numberB)
{
    int i = 1;
    int result = 1;
    while (i <= numberB)
    {
        result *= numberA;
        i ++;
    }
    return result;
}
int result = GetNumberInDegree(numberA, numberB);
Console.WriteLine(result);