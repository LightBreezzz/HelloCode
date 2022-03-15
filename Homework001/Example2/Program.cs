int A = 5;
int B = 2;

int max = A;
int min = B;

if ( B > max ) max = B;
if ( A < min ) min = A;

Console.Write("min = ");
Console.WriteLine( min );
Console.Write("max = ");
Console.WriteLine( max );