/*
    Напишите программу, которая выводит
    случайное трёхзначное число и удаляет вторую цифру
    этого числа.
*/

int GetNumber(int number)
{
    int fest = number;
    int Last = number;
    Console.WriteLine(number);

    while (fest < 999 & Last > 99)
    {
        Last /= 100; 
        fest %= 10;
        Console.Write(Last);
        Console.WriteLine(fest);
    }
    return Last;
}

int randnumber = new Random().Next(100, 1000);
int count = GetNumber(randnumber);