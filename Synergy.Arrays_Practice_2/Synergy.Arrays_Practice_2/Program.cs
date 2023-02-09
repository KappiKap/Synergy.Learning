int[] Array1 = { 1, 2, 37 , 4, 5, 11, 7, 8, 9, 10, 11, 12, 22, 14, 15, 16,17,18,19};
int [] Array2 = new int [Array1.Length/2]; // четный
int [] Array3 = new int [(Array1.Length/2)+1]; //нечетный
int j = 0;
int k = 0;
for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i] % 2 == 0)
    {
        Array2[j] = Array1[i];
        j++;
    }
    else
    {
        Array3[k] = Array1[i];
        k++;

    }
}
Array.Sort(Array2);
Array.Sort(Array3);

for (int n = 0; n < Array2.Length; n++)
{
    Console.Write($"{Array2[n]} ");
}
Console.WriteLine();
for (int q = 0; q < Array3.Length; q++)
{
    Console.Write($"{Array3[q]} ");
}