int[] array = {1,23,43,54,98,34,23,98,65};

int n = array.Length;
int find = 98;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}