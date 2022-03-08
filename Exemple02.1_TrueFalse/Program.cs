Console.WriteLine("Ведите число №1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите число №2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("False");
}