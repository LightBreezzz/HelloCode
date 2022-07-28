int GetNumberOfDigit(int number)
{
    int NumberOfDigit = 0;
    while (number > 0)
    {
        number /= 10;
        NumberOfDigit++;
        //Console.WriteLine(number);
    }
    return NumberOfDigit;
}

while (true)
{
    Console.WriteLine("Ведите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int numberOfDigit = GetNumberOfDigit(number);
    Console.WriteLine($"колличество цифр {numberOfDigit}");
}