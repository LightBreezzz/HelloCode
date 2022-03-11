int[] array = { 41, 27, 85, 32, 4, 45, 65, 67, 73, 85 };

int n = array.Length;
int find = 85;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}