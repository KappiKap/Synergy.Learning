int[] array_1 = { 5, 7, 11, 22, 16, 4, 3, 6, 9 , 33};

//Console.WriteLine(array_1.Max() - array_1.Min()); 

int max = array_1[0];
int min = array_1[0];

for (int i = 0; i < array_1.Length; i++)
{
    for (int k = 0; k < array_1.Length; k++)
    {
        if (array_1[i] < array_1[k] & max < array_1[k])
        {
            max = array_1[k];
        }
    }
}

for (int j = 0; j < array_1.Length; j++)
{
    for (int q = 0; q < array_1.Length; q++)
    {
        if (array_1[j] > array_1[q] & min > array_1[q])
        {
            min = array_1[q];
        }
    }
}
Console.WriteLine(max);
Console.WriteLine(min);

Console.WriteLine(max - min);