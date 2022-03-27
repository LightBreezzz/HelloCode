int Number = new int();
System.Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());

int Number1 = Number / 10;
int Number2 = Number % 10;

if (Number1 % Number2 == 0)
    {
        Console.WriteLine("Trye");
    }
else
    {
        Console.WriteLine("False");
    }