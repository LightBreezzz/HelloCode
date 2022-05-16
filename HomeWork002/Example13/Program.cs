/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetTreeNumbersOfNumber(int number)
{
    int count = number;
    System.Console.WriteLine(number);

    while (count > 999)
    {
        count /= 10;
    }
    return count;
}
int GetTreeNumberOfNumber(int count)
{
        if (count > 99)
        {
            count %= 10;
            Console.Write(count);
        }
        else
        {
            Console.Write("No");
        }
        return count;
}

int randnumber = new Random().Next(1, 9999);
int count = GetTreeNumbersOfNumber(randnumber);
int result = GetTreeNumberOfNumber(count);
Console.WriteLine($" third number out of {randnumber} " );