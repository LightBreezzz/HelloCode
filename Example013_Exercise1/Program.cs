//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - Сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приСтупом согласие прусского короля. "
            + "Вы так краСноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             123456
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ' , '|' );
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к' , 'К' );
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С' , 'с' );
Console.WriteLine(newText);
