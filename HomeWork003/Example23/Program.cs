/* 
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumberN(int number)
{
    int NumberA = 1;
    int count = 1;
        Console.Write($"{number} -> ");
    while (NumberA <= number)
    {
        count = NumberA * NumberA;
        Console.Write(count);
        for (int i = 0; i < 1; i+=2)
        {
            if (i != count -2)
            {
                Console.Write("; ");
            }   
        }
        NumberA++;
    }
    return count; 
}

int randnumber = new Random().Next(1, 11);
int count = GetNumberN(randnumber);
