int[] Array = { 1, 2, 3, 4, 5 };
int[] Array2 = new int[Array.Length + 1];

for (int i = 0; i < Array2.Length; i++)
{
    if (i == 0)
    {
        Array2[i] = i;
        Console.WriteLine(Array2[i]);
    } else if(i == Array2.Length-1)
    {
        Array2[i] = 6;
        Console.WriteLine(Array2[i]);
    }
    else if(Array[i-1] == 3) {
        continue;
    }
    else {
        Array2[i] = Array[i - 1];
        Console.WriteLine(Array2[i]);
    }
}