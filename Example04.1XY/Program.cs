Console.WriteLine("Введите x and y");

int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая чктвердь");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Вторая чктвердь");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья чктвердь");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Четвертая чктвердь");
}