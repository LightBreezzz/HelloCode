/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Number = new Random().Next(100, 1000);
Console.WriteLine(Number);

int result = Number / 10;
//Console.WriteLine(result);

result %= 10;
Console.WriteLine($"{result} is the sekond number out of {Number}");