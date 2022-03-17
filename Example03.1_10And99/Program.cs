int GetMaxLetterOfNumber(int number)
{
    int result = number % 10;
    int letter2 = number / 10;
    if (result < letter2)
    {
        result = letter2;
    }
    return result;
}


int randNumber = new Random().Next(10, 100);
int result = GetMaxLetterOfNumber(randNumber);
Console.WriteLine($"у числа {randNumber} наибольшая цифра {result}");

//Console.WriteLine($"у числа " + rendNumber + " наибольшая цифра " + result");

