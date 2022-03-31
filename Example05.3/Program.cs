// задачв 30: Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке.
// [0,1,0,1,1,1,0,1]

int [] makeArray(int [] array)
{
    int [] newArray = new int[array.Length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i]
        = rnd.Next(0, 2);    
    }
    return newArray;
}

void printArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] arr = new int[8];
arr = makeArray(arr);
printArray(arr);