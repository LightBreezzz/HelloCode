// Vid 1
void Method1()
{
    Console.WriteLine("Author");
}
//Method1();


// Vid2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text to the masseg");

async void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text", count: 4);


// Vid3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Vid4

// string Method4(int count, string Text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + Text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);



// For

string Method4(int count, string Text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + Text;

    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);


//multiplication table

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
