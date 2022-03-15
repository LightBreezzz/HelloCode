int A = new Random().Next(1,10);
int B = new Random().Next(1,10);
int C = new Random().Next(1,10);

Console.Write( A );
Console.Write( B );
Console.WriteLine( C );

int max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write( "max = " );
Console.Write( max );
