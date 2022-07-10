/*
    Напишите программу, которая принимает на вход координаты двух точек 
    и находит ростояние между ними в 3D пространстве
    A(3,6,8); B(2,1,-7) -> 15.84
*/

Console.WriteLine("Введите координаты точек A");

int numberAx = Convert.ToInt32(Console.ReadLine());
int numberAy = Convert.ToInt32(Console.ReadLine());
int numberAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точек B");

int numberBx = Convert.ToInt32(Console.ReadLine());
int numberBy = Convert.ToInt32(Console.ReadLine());
int numberBz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({numberAx},{numberAy},{numberAz})");
Console.WriteLine($"A({numberBx},{numberBy},{numberBz})");


double NumberX = (numberAx - numberBx);
double NumberY = (numberAy - numberBy);
double NumberZ = (numberAz - numberBz);
NumberX = Math.Pow(NumberX, 2);
NumberY = Math.Pow(NumberY, 2);
NumberZ = Math.Pow(NumberZ, 2);


double result = Math.Sqrt (NumberX + NumberY + NumberZ);
result = Math.Round(result,2);

Console.WriteLine($"A({numberAx},{numberAy},{numberAz}); B({numberBx},{numberBy},{numberBz}) -> ({result})");



