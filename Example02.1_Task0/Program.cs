
var totalCount = 0;
string[] elements = { "Rem", "Hisoka", "Gon", "Monkey D Luffy", "Alvida", "Shank" };
totalCount = elements.Count();
//Console.WriteLine(totalCount);


string Array(string[] elements)
{
    //string[] arr = {"32fg", "fb", "d=4", "dfgg"};
    string result = String.Empty;
    for (int i = 0; i < elements.Length; i++)
    {
        string count = elements[i];
        result = result + count;
        Console.WriteLine(result);
        result = String.Empty;
    }
    return result;
}

 Array(elements);
Console.WriteLine(Array);

/*string Method4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
         result = result + Text;
         i++;
    }
    return result;
}
 string res = Method4(totalCount, text);
Console.WriteLine(res);



string Method(string elements)
{
        string result = String.Empty;
    for(int i = 0; i < totalCount; i++)
    {
        result = result + elements;
        System.Console.WriteLine(result);
    }
}

string[] count = Method(elements);


string Method4(int totalCount, string elements)
{
    string result = String.Empty;
    for(int i = 0; i < totalCount; i++)
    {
        result = result + elements;
        System.Console.WriteLine(result);

    }
    return result;
}*/
