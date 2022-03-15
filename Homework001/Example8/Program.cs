int N = new Random().Next(10, 20);
Console.WriteLine(N);
int A = 2;

while (N > A)
{
    if (A % 2 == 0)
    {
        Console.WriteLine(A);
    }
    A++;
}