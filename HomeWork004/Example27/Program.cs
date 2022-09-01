/*
Напиши программу, которая принимает на вход число и выдает сумму в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int Numbers = Convert.ToString(number).Length;
    int  count = 0;
    int result = 0;
    for (int i = 0; i < Numbers; i++)
    {
        count = number - number % 10;
        result = result + (number - count);
        number = number / 10;
    }
    return result;
}
int result = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе - {result}");