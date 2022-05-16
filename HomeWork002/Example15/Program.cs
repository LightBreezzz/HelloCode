/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int days = new int();
Console.WriteLine("Ведите число");
days = Convert.ToInt32(Console.ReadLine());

switch (days)
{
    case 1:
        {
            Console.Write($"{days} -> ");
            Console.WriteLine("No");
            break;
        }
    case 2:
        {
            Console.Write($"{days} -> ");
            Console.WriteLine("No");
            break;
        }
    case 3:
        {
            Console.Write($"{days} -> ");
            Console.WriteLine("No");
            break;
        }
    case 4:
        {
            Console.Write($"{days} -> ");
            Console.WriteLine("No");
            break;
        }    
    case 5:
    {
        Console.Write($"{days} -> ");
        Console.WriteLine("No");
        break;
    }
    case 6:
    {
        Console.Write($"{days} -> ");
        Console.WriteLine("Yas");
        break;
    }
    case 7:
    {
        Console.Write($"{days} -> ");
        Console.WriteLine("Yas");
        break;
    }    
}
