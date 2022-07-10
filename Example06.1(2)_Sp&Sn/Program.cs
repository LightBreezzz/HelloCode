int[] CreateAndFillArray()
{
    int [] array = new int [12];
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] arr = CreateAndFillArray();

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {   
        Console.Write(arr[i]);
        if (i != arr.Length -1)
        {
            Console.Write(",");
        }   
    } 
    Console.WriteLine("]");
}

void PositiveAndNegativeNumbers(int[] arr)
{
    int positive = 0;
    int nigative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=0)
        {
        positive += arr[i];
        }
        else
        {
            nigative += arr[i];
        }
    }
    Console.Write($"Сумма положительных - {positive}; Сумма отрицательных - {nigative}");
}
printArray(arr);
PositiveAndNegativeNumbers(arr);