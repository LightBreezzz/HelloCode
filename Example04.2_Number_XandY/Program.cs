Console.WriteLine("Введите координаты двух точек");

int numberAx = Convert.ToInt32(Console.ReadLine());
int numberAy = Convert.ToInt32(Console.ReadLine());
int numberBx = Convert.ToInt32(Console.ReadLine());
int numberBy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({numberAx},{numberAy})");
Console.WriteLine($"B({numberBx},{numberBy})");

double result = Math.Sqrt((numberAy - numberAx)^2 + (numberBy - numberBx)^2);
result = Math.Round(result,2);

Console.WriteLine($"A({numberAx},{numberAy}); B({numberBx},{numberBy}) -> ({result})");

