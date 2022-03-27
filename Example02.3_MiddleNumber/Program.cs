int Number = new int();
System.Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());

Number /= 10;
Number %= 10;

Console.WriteLine(Number);
