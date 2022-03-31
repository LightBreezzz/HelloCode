Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int count = 0;
while (count <= number)
{
    result += count;
    count++;
}
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {result} ");