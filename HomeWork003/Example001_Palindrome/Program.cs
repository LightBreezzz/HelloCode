int reversNumber(int number)
{
    int reversNumber = new int();

    while (number > 0)
    {
        int lastDigit = number % 10;
        reversNumber = reversNumber * 10 + lastDigit;
        number /= 10;
    }
    return reversNumber;
}

string InNumberPolindrom(int number)
{
    string returnMassage = $"{number}";

    int reversedNumber = reversNumber(number);
    if (reversedNumber == number)
    {
        returnMassage += (" - это полиндром");
    }
    else
    {
        returnMassage += (" - это не полиндром");
    }
    return returnMassage;
}

int number = Convert.ToInt32(Console.ReadLine());
string returnMassage = InNumberPolindrom(number);
System.Console.WriteLine(returnMassage);





/*int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string returnMassage = $"{fiveDigitNumber}";
if (fiveDigitNumber > 9999 && fiveDigitNumber < 100000)
{
    int[] digit = new int[5];
    for (int i = 0; i < digit.Length; i++)
    {
        digit[i] = fiveDigitNumber % 10;
        fiveDigitNumber /= 10;
    }
    if(digit[0] == digit[4] && digit[1] == digit[3])
    {
        returnMassage += (" - это полиндром");
    }
    else
    {
        returnMassage += (" - это не полиндром");
    }
}
else
    {
        returnMassage += (" - это не пятизначное число");
    }
    System.Console.WriteLine(returnMassage);
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
*/